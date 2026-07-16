using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace WinFrmApp_Workout
{
    public partial class Frm02_Main : Form
    {
        #region 初始設定

        //判斷是否為登入模式並記錄帳號
        public Frm02_Main(bool loginStatus, string accountName)
        {
            InitializeComponent();
            this._isLoggedIn = loginStatus;
            this._currentAccount = accountName;
        }
        public bool _isLoggedIn = false;
        public string _currentAccount = "Member";

        //初始載入資料
        private void Frm02_Main_Load(object sender, EventArgs e)
        {
            LoadAllData();
            LoadManualData();
            UpdateCmbModeUI();
            RefreshData();
        }
        private void LoadAllData()
        {
            this.exercisesTableAdapter.Fill(this.ExerciseDataSet.Exercises);
            this.membersTableAdapter.Fill(this.ExerciseDataSet.Members);
            this.manualTableAdapter.Fill(this.ExerciseDataSet.Manual);
        }
        private void RefreshData()
        {
            //判斷目前為資料庫or常用
            string mode = cmbMode.Text;
            IEnumerable<ExerciseDataSet.ExercisesRow> baseData;
            if (mode.Contains("常用"))
            {
                baseData = ExerciseDataSet.Exercises.Where(x => x.Favorite);
            }
            else
            {
                baseData = ExerciseDataSet.Exercises.AsEnumerable();
            }

            //是否有篩選部位
            if (_currentFilterMuscles != null && _currentFilterMuscles.Count > 0)
            {
                baseData = baseData.Where(x => _currentFilterMuscles.Contains(x.PrimaryMuscles));
            }

            //讀取頁數
            int totalCount = baseData.Count();
            labTotalCount.Text = $"共 {totalCount} 筆";

            int pageSize;
            if (!int.TryParse(cmbPageSize.Text, out pageSize)) pageSize = totalCount > 0 ? totalCount : 1;

            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (totalPages == 0) totalPages = 1;

            cmbCurrentPage.SelectedIndexChanged -= cmbCurrentPage_SelectedIndexChanged;
            string currentText = cmbCurrentPage.Text;
            cmbCurrentPage.Items.Clear();
            cmbCurrentPage.Items.AddRange(Enumerable.Range(1, totalPages).Select(i => i.ToString()).ToArray());

            if (cmbCurrentPage.Items.Contains(currentText))
                cmbCurrentPage.Text = currentText;
            else
                cmbCurrentPage.SelectedIndex = 0;
            cmbCurrentPage.SelectedIndexChanged += cmbCurrentPage_SelectedIndexChanged;

            int currentPage = 1;
            int.TryParse(cmbCurrentPage.Text, out currentPage);

            var pagedData = baseData.Skip((currentPage - 1) * pageSize).Take(pageSize);

            //照片資料
            if (pagedData.Any())
            {
                DataTable dt = pagedData.CopyToDataTable();
                dgvAll.AutoGenerateColumns = false;
                dgvAll.DataSource = dt;
            }
            else
            {
                dgvAll.DataSource = null;
                picStart.Image = null;
                picFinish.Image = null;
            }
        }
        #endregion

        #region 登入登出
        private void CheckLoginRequired()
        {
            if (!_isLoggedIn && cmbMode.Text.Contains("需登入"))
            {
                LoginMessage();
            }
            RefreshData();
        }
        private void LoginMessage()
        {
            var result = MessageBox.Show("此功能僅限會員使用，是否現在登入？", "會員限定", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Frm01_Login loginForm = new Frm01_Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this._isLoggedIn = true;
                    this._currentAccount = loginForm.Tag.ToString();
                    UpdateCmbModeUI();
                    LoadManualData();
                    cmbMode.Text = cmbMode.Text.Replace("(需登入)", "");       //把需登入的字樣拿掉
                }
                else
                {
                    //不登入，以訪客身份繼續
                    cmbMode.SelectedIndex = 0;
                }
            }
            else
            {
                cmbMode.SelectedIndex = 0;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("即將返回登入頁面", "切換使用者", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region 資料庫模式
        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckLoginRequired();
        }
        private void UpdateCmbModeUI()
        {
            cmbMode.Items.Clear();
            if (_isLoggedIn)
            {
                cmbMode.Items.Add("動作資料庫");
                cmbMode.Items.Add("常用");
            }
            else
            {
                cmbMode.Items.Add("動作資料庫");
                cmbMode.Items.Add("常用(需登入)");
            }

            cmbMode.SelectedIndex = 0;
        }
        private void dgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //星號點擊
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvAll.Columns[e.ColumnIndex].Name == "colFavorite")
            {
                if (!this._isLoggedIn)
                {
                    LoginMessage();
                    return;
                }
                //點完不跳回第一行
                int currentRowIndex = e.RowIndex;
                int firstDisplayedIndex = dgvAll.FirstDisplayedScrollingRowIndex;

                int id = (int)dgvAll.Rows[e.RowIndex].Cells["colExerciseID"].Value;
                var row = ExerciseDataSet.Exercises.FindByExerciseID(id);

                if (row != null)
                {
                    row.Favorite = !row.Favorite;
                    if (row.Favorite == false)
                    {
                        var result = MessageBox.Show("確定取消常用？", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No) { row.Favorite = true; }
                        this.exercisesTableAdapter.Update(this.ExerciseDataSet.Exercises);
                    }
                    RefreshData();
                    if (dgvAll.Rows.Count > 0 && currentRowIndex < dgvAll.Rows.Count)
                    {
                        if (firstDisplayedIndex >= 0 && firstDisplayedIndex < dgvAll.Rows.Count)
                            dgvAll.FirstDisplayedScrollingRowIndex = firstDisplayedIndex;
                        dgvAll.CurrentCell = dgvAll.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    }
                }
            }
        }
        private void dgvAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //讓常用以★表示
            if (dgvAll.Columns[e.ColumnIndex].Name == "colFavorite" && e.Value != null)
            {
                if (e.Value is bool isFavorite)
                {
                    e.Value = isFavorite ? "★" : "";
                    e.FormattingApplied = true;
                }
            }
        }

        #endregion

        #region 頁數
        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCurrentPage.SelectedIndex = 0;
            RefreshData();
        }
        private void cmbCurrentPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            cmbCurrentPage.SelectedIndex = 0;
        }
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            cmbCurrentPage.SelectedIndex = Math.Max(0, cmbCurrentPage.SelectedIndex - 1);
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            cmbCurrentPage.SelectedIndex = Math.Min(cmbCurrentPage.Items.Count - 1, cmbCurrentPage.SelectedIndex + 1);
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            cmbCurrentPage.SelectedIndex = cmbCurrentPage.Items.Count - 1;
        }
        #endregion

        #region 部位篩選
        List<string> _currentFilterMuscles = new List<string>();     // 記錄目前選中的部位
        private void FilterByMuscles(List<string> muscles)
        {
            _currentFilterMuscles = muscles;

            //重設頁碼到第一頁
            if (cmbCurrentPage.Items.Count > 0)
            {
                cmbCurrentPage.SelectedIndex = 0;
            }
            RefreshData();
        }
        private void btnChest_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "chest" });
        }
        private void btnAbs_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "abdominals" });
        }
        private void btnBicep_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "biceps" });
        }
        private void btnForearm_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "forearms" });
        }
        private void btnQuad_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "quadriceps" });
        }
        private void btnAdductor_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "adductors" });
        }
        private void btnShoulder_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "shoulders" });
        }
        private void btnNeck_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "neck" });
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "lats", "lower back", "middle back", "traps" });
        }
        private void btnGlute_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "glutes" });
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "hamstrings" });
        }
        private void btnAbd_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "abductors" });
        }
        private void btnCalf_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "calves" });
        }
        private void btnTricep_Click(object sender, EventArgs e)
        {
            FilterByMuscles(new List<string> { "triceps" });
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            _currentFilterMuscles.Clear();
            cmbCurrentPage.SelectedIndex = 0;
            RefreshData();
        }
        #endregion

        #region 課表
        private void LoadManualData()
        {
            btnDelete.Enabled = btnUp.Enabled = btnDown.Enabled = false;

            if (_isLoggedIn)
            {
                this.manualTableAdapter.Fill(this.ExerciseDataSet.Manual);
                DataView dv = new DataView(this.ExerciseDataSet.Manual);
                dv.RowFilter = $"Account = '{this._currentAccount}'";
                dv.Sort = "Sort ASC";
                dgvManual.AutoGenerateColumns = false;
                dgvManual.DataSource = dv;

                //有資料才顯示圖表
                if (dv.Count > 0)
                {
                    btnDelete.Enabled = btnUp.Enabled = btnDown.Enabled = true;
                    UpdateChart(dv);
                }
                else
                {
                    chart1.Series[0].Points.Clear();
                }
            }
            else
            {
                //訪客身份則清空資料
                dgvManual.DataSource = null;
                chart1.Series[0].Points.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!_isLoggedIn)
            {
                LoginMessage();
                return;
            }
            if (dgvAll.CurrentRow == null) return;

            DataRowView drv = dgvAll.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            try
            {
                int exerciseId = Convert.ToInt32(drv["ExerciseID"]);
                var exercise = this.ExerciseDataSet.Exercises.FindByExerciseID(exerciseId);

                if (exercise != null)
                {
                    int nextSort = (this.ExerciseDataSet.Manual
                        .Where(x => x.Account == this._currentAccount)
                        .Max(x => (int?)x.Sort) ?? 0) + 1;

                    this.manualTableAdapter.Insert(
                        exercise.ExerciseID,
                        exercise.Name,
                        exercise.ForceType,
                        exercise.Level,
                        exercise.Mechanic,
                        exercise.Equipment,
                        exercise.PrimaryMuscles,
                        exercise.Category,
                        exercise.ImagesStart,
                        exercise.ImagesFinish,
                        exercise.ImagesStartBinary,
                        exercise.ImagesFinishBinary,
                        this._currentAccount,
                        nextSort
                    );
                    LoadManualData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加入課表");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvManual.CurrentRow == null) return;

            int autoID = (int)dgvManual.CurrentRow.Cells["col2AutoID"].Value;

            var row = this.ExerciseDataSet.Manual.FindByAutoID(autoID);
            if (row != null)
            {
                row.Delete();
                this.manualTableAdapter.Update(this.ExerciseDataSet.Manual);
                LoadManualData();
            }
        }
        private void MoveSort(int direction)
        {
            if (dgvManual.CurrentRow == null) return;

            //目前選中的AutoID
            int currentAutoID = (int)dgvManual.CurrentRow.Cells["col2AutoID"].Value;
            var currentRow = this.ExerciseDataSet.Manual.FindByAutoID(currentAutoID);

            if (currentRow != null)
            {
                //尋找同帳號且 Sort 比目前大或小
                ExerciseDataSet.ManualRow targetRow = null;
                var sameAccountRows = this.ExerciseDataSet.Manual.Where(x => x.Account == this._currentAccount);

                if (direction < 0) //往上移：找比目前 Sort 小的最大值
                    targetRow = sameAccountRows.Where(x => x.Sort < currentRow.Sort).OrderByDescending(x => x.Sort).FirstOrDefault();
                else //往下移：找比目前 Sort 大的最小值
                    targetRow = sameAccountRows.Where(x => x.Sort > currentRow.Sort).OrderBy(x => x.Sort).FirstOrDefault();

                //交換Sort 值
                if (targetRow != null)
                {
                    int temp = currentRow.Sort;
                    currentRow.Sort = targetRow.Sort;
                    targetRow.Sort = temp;

                    this.manualTableAdapter.Update(this.ExerciseDataSet.Manual);
                    LoadManualData();

                    //讓選取列停在移動後的位置
                    foreach (DataGridViewRow dgvRow in dgvManual.Rows)
                    {
                        if ((int)dgvRow.Cells["col2AutoID"].Value == currentAutoID)
                        {
                            dgvManual.CurrentCell = dgvRow.Cells[0];
                            break;
                        }
                    }
                }
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveSort(-1);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveSort(1);
        }
        #endregion

        #region 圖表
        private void DisplayImages(byte[] startImg, byte[] finishImg)
        {
            try
            {
                if (startImg != null && startImg.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(startImg))
                        picStart.Image = new Bitmap(ms);
                }
                else { picStart.Image = null; }

                if (finishImg != null && finishImg.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(finishImg))
                        picFinish.Image = new Bitmap(ms);
                }
                else { picFinish.Image = null; }
            }
            catch { picStart.Image = picFinish.Image = null; }
        }
        private void dgvAll_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAll.CurrentRow == null) return;
            DataRowView drv = dgvAll.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null)
            {
                byte[] start = drv["ImagesStartBinary"] as byte[];
                byte[] finish = drv["ImagesFinishBinary"] as byte[];
                DisplayImages(start, finish);
            }
        }
        private void dgvManual_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvManual.CurrentRow == null) return;
            DataRowView drv = dgvManual.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null)
            {
                byte[] start = drv["ImagesStartBinary"] as byte[];
                byte[] finish = drv["ImagesFinishBinary"] as byte[];
                DisplayImages(start, finish);
            }
        }
        private void UpdateChart(DataView dv)
        {
            var colorSettings = new Dictionary<string, Color>
    {
        { "beginner", Color.DodgerBlue },
        { "intermediate", Color.Orange },
        { "expert", Color.Crimson }
    };
            //統計
            var stats = dv.Cast<DataRowView>()
                          .Select(r => r["Level"].ToString().ToLower())
                          .GroupBy(lvl => lvl)
                          .ToDictionary(g => g.Key, g => g.Count());

            chart1.Series[0].Points.Clear();

            string[] targetLevels = { "beginner","intermediate", "expert" };
            foreach (var level in targetLevels)
            {
                int count = stats.ContainsKey(level) ? stats[level] : 0;
                int i = chart1.Series[0].Points.AddY(count);
                var point = chart1.Series[0].Points[i];

                point.Color = colorSettings[level];
                point.LegendText = level;

                if (count == 0)
                {
                    point.Label = "";
                }
                else
                {
                    point.Label = "#PERCENT{P0}";          //只顯示百分比
                }
                point.Font = new Font("Noto Sans HK", 14, FontStyle.Bold);
            }
        }
        #endregion
    }
}