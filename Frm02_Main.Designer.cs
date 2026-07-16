namespace WinFrmApp_Workout
{
    partial class Frm02_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm02_Main));
            this.btnChest = new System.Windows.Forms.Button();
            this.btnBicep = new System.Windows.Forms.Button();
            this.btnForearm = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnQuad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGlute = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.Button();
            this.btnCalf = new System.Windows.Forms.Button();
            this.btnShoulder = new System.Windows.Forms.Button();
            this.btnTricep = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdductor = new System.Windows.Forms.Button();
            this.btnAbd = new System.Windows.Forms.Button();
            this.btnNeck = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.picHuman = new System.Windows.Forms.PictureBox();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.colFavorite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExerciseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimaryMuscles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.labPageSize = new System.Windows.Forms.Label();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.cmbCurrentPage = new System.Windows.Forms.ComboBox();
            this.labCurrentPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.labTotalCount = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvManual = new System.Windows.Forms.DataGridView();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExerciseDataSet = new WinFrmApp_Workout.ExerciseDataSet();
            this.exercisesTableAdapter = new WinFrmApp_Workout.ExerciseDataSetTableAdapters.ExercisesTableAdapter();
            this.tableAdapterManager = new WinFrmApp_Workout.ExerciseDataSetTableAdapters.TableAdapterManager();
            this.manualTableAdapter = new WinFrmApp_Workout.ExerciseDataSetTableAdapters.ManualTableAdapter();
            this.membersTableAdapter = new WinFrmApp_Workout.ExerciseDataSetTableAdapters.MembersTableAdapter();
            this.picFinish = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.col2ExerciseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2ForceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Mechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2PrimaryMuscles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2AutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChest
            // 
            this.btnChest.AutoSize = true;
            this.btnChest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChest.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChest.Location = new System.Drawing.Point(122, 155);
            this.btnChest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(53, 29);
            this.btnChest.TabIndex = 1;
            this.btnChest.Text = "Chest";
            this.btnChest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChest.UseVisualStyleBackColor = false;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnBicep
            // 
            this.btnBicep.AutoSize = true;
            this.btnBicep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBicep.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBicep.Location = new System.Drawing.Point(41, 165);
            this.btnBicep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBicep.Name = "btnBicep";
            this.btnBicep.Size = new System.Drawing.Size(60, 29);
            this.btnBicep.TabIndex = 2;
            this.btnBicep.Text = "Biceps";
            this.btnBicep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBicep.UseVisualStyleBackColor = false;
            this.btnBicep.Click += new System.EventHandler(this.btnBicep_Click);
            // 
            // btnForearm
            // 
            this.btnForearm.AutoSize = true;
            this.btnForearm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnForearm.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForearm.Location = new System.Drawing.Point(9, 206);
            this.btnForearm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForearm.Name = "btnForearm";
            this.btnForearm.Size = new System.Drawing.Size(76, 29);
            this.btnForearm.TabIndex = 3;
            this.btnForearm.Text = "Forearms";
            this.btnForearm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForearm.UseVisualStyleBackColor = false;
            this.btnForearm.Click += new System.EventHandler(this.btnForearm_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.AutoSize = true;
            this.btnAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbs.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAbs.Location = new System.Drawing.Point(128, 213);
            this.btnAbs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(41, 29);
            this.btnAbs.TabIndex = 4;
            this.btnAbs.Text = "Abs";
            this.btnAbs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnQuad
            // 
            this.btnQuad.AutoSize = true;
            this.btnQuad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuad.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuad.Location = new System.Drawing.Point(77, 275);
            this.btnQuad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(58, 29);
            this.btnQuad.TabIndex = 5;
            this.btnQuad.Text = "Quads";
            this.btnQuad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuad.UseVisualStyleBackColor = false;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(357, 178);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 29);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGlute
            // 
            this.btnGlute.AutoSize = true;
            this.btnGlute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGlute.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGlute.Location = new System.Drawing.Point(354, 232);
            this.btnGlute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGlute.Name = "btnGlute";
            this.btnGlute.Size = new System.Drawing.Size(58, 29);
            this.btnGlute.TabIndex = 7;
            this.btnGlute.Text = "Glutes";
            this.btnGlute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGlute.UseVisualStyleBackColor = false;
            this.btnGlute.Click += new System.EventHandler(this.btnGlute_Click);
            // 
            // btnHam
            // 
            this.btnHam.AutoSize = true;
            this.btnHam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHam.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHam.Location = new System.Drawing.Point(333, 286);
            this.btnHam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(53, 29);
            this.btnHam.TabIndex = 8;
            this.btnHam.Text = "Hams";
            this.btnHam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHam.UseVisualStyleBackColor = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // btnCalf
            // 
            this.btnCalf.AutoSize = true;
            this.btnCalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalf.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalf.Location = new System.Drawing.Point(382, 373);
            this.btnCalf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalf.Name = "btnCalf";
            this.btnCalf.Size = new System.Drawing.Size(58, 29);
            this.btnCalf.TabIndex = 9;
            this.btnCalf.Text = "Calves";
            this.btnCalf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalf.UseVisualStyleBackColor = false;
            this.btnCalf.Click += new System.EventHandler(this.btnCalf_Click);
            // 
            // btnShoulder
            // 
            this.btnShoulder.AutoSize = true;
            this.btnShoulder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShoulder.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShoulder.Location = new System.Drawing.Point(186, 116);
            this.btnShoulder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShoulder.Name = "btnShoulder";
            this.btnShoulder.Size = new System.Drawing.Size(81, 29);
            this.btnShoulder.TabIndex = 10;
            this.btnShoulder.Text = "Shoulders";
            this.btnShoulder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShoulder.UseVisualStyleBackColor = false;
            this.btnShoulder.Click += new System.EventHandler(this.btnShoulder_Click);
            // 
            // btnTricep
            // 
            this.btnTricep.AutoSize = true;
            this.btnTricep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTricep.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTricep.Location = new System.Drawing.Point(431, 155);
            this.btnTricep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTricep.Name = "btnTricep";
            this.btnTricep.Size = new System.Drawing.Size(63, 29);
            this.btnTricep.TabIndex = 11;
            this.btnTricep.Text = "Triceps";
            this.btnTricep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTricep.UseVisualStyleBackColor = false;
            this.btnTricep.Click += new System.EventHandler(this.btnTricep_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdductor);
            this.panel1.Controls.Add(this.btnAbd);
            this.panel1.Controls.Add(this.btnNeck);
            this.panel1.Controls.Add(this.btnTricep);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnChest);
            this.panel1.Controls.Add(this.btnShoulder);
            this.panel1.Controls.Add(this.btnBicep);
            this.panel1.Controls.Add(this.btnCalf);
            this.panel1.Controls.Add(this.btnForearm);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.btnAbs);
            this.panel1.Controls.Add(this.btnGlute);
            this.panel1.Controls.Add(this.btnQuad);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.picHuman);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 541);
            this.panel1.TabIndex = 12;
            // 
            // btnAdductor
            // 
            this.btnAdductor.AutoSize = true;
            this.btnAdductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdductor.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdductor.Location = new System.Drawing.Point(126, 306);
            this.btnAdductor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdductor.Name = "btnAdductor";
            this.btnAdductor.Size = new System.Drawing.Size(43, 29);
            this.btnAdductor.TabIndex = 14;
            this.btnAdductor.Text = "Add";
            this.btnAdductor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdductor.UseVisualStyleBackColor = false;
            this.btnAdductor.Click += new System.EventHandler(this.btnAdductor_Click);
            // 
            // btnAbd
            // 
            this.btnAbd.AutoSize = true;
            this.btnAbd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAbd.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAbd.Location = new System.Drawing.Point(417, 287);
            this.btnAbd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbd.Name = "btnAbd";
            this.btnAbd.Size = new System.Drawing.Size(43, 29);
            this.btnAbd.TabIndex = 13;
            this.btnAbd.Text = "Abd";
            this.btnAbd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbd.UseVisualStyleBackColor = false;
            this.btnAbd.Click += new System.EventHandler(this.btnAbd_Click);
            // 
            // btnNeck
            // 
            this.btnNeck.AutoSize = true;
            this.btnNeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNeck.Font = new System.Drawing.Font("Noto Sans HK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNeck.Location = new System.Drawing.Point(357, 106);
            this.btnNeck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNeck.Name = "btnNeck";
            this.btnNeck.Size = new System.Drawing.Size(49, 29);
            this.btnNeck.TabIndex = 12;
            this.btnNeck.Text = "Neck";
            this.btnNeck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNeck.UseVisualStyleBackColor = false;
            this.btnNeck.Click += new System.EventHandler(this.btnNeck_Click);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Location = new System.Drawing.Point(223, 461);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(84, 34);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "顯示全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // picHuman
            // 
            this.picHuman.BackColor = System.Drawing.Color.Transparent;
            this.picHuman.Image = global::WinFrmApp_Workout.Properties.Resources.HumanBody;
            this.picHuman.Location = new System.Drawing.Point(22, 6);
            this.picHuman.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picHuman.Name = "picHuman";
            this.picHuman.Size = new System.Drawing.Size(487, 521);
            this.picHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHuman.TabIndex = 0;
            this.picHuman.TabStop = false;
            // 
            // dgvAll
            // 
            this.dgvAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAll.ColumnHeadersHeight = 35;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFavorite,
            this.colExerciseID,
            this.colName,
            this.colForceType,
            this.colLevel,
            this.colMechanic,
            this.colEquipment,
            this.colPrimaryMuscles,
            this.colCategory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAll.Location = new System.Drawing.Point(3, 127);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.RowHeadersWidth = 25;
            this.dgvAll.RowTemplate.Height = 24;
            this.dgvAll.Size = new System.Drawing.Size(1093, 380);
            this.dgvAll.TabIndex = 13;
            this.dgvAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellClick);
            this.dgvAll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAll_CellFormatting);
            this.dgvAll.SelectionChanged += new System.EventHandler(this.dgvAll_SelectionChanged);
            // 
            // colFavorite
            // 
            this.colFavorite.DataPropertyName = "Favorite";
            this.colFavorite.HeaderText = "常用";
            this.colFavorite.Name = "colFavorite";
            this.colFavorite.ReadOnly = true;
            this.colFavorite.Width = 50;
            // 
            // colExerciseID
            // 
            this.colExerciseID.DataPropertyName = "ExerciseID";
            this.colExerciseID.HeaderText = "編號";
            this.colExerciseID.Name = "colExerciseID";
            this.colExerciseID.ReadOnly = true;
            this.colExerciseID.Width = 50;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colForceType
            // 
            this.colForceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colForceType.DataPropertyName = "ForceType";
            this.colForceType.HeaderText = "Force Type";
            this.colForceType.Name = "colForceType";
            this.colForceType.ReadOnly = true;
            this.colForceType.Width = 117;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLevel.DataPropertyName = "Level";
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.Width = 75;
            // 
            // colMechanic
            // 
            this.colMechanic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMechanic.DataPropertyName = "Mechanic";
            this.colMechanic.HeaderText = "Mechanic";
            this.colMechanic.Name = "colMechanic";
            this.colMechanic.ReadOnly = true;
            this.colMechanic.Width = 106;
            // 
            // colEquipment
            // 
            this.colEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEquipment.DataPropertyName = "Equipment";
            this.colEquipment.HeaderText = "Equipment";
            this.colEquipment.Name = "colEquipment";
            this.colEquipment.ReadOnly = true;
            this.colEquipment.Width = 118;
            // 
            // colPrimaryMuscles
            // 
            this.colPrimaryMuscles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrimaryMuscles.DataPropertyName = "PrimaryMuscles";
            this.colPrimaryMuscles.HeaderText = "Primary Muscles";
            this.colPrimaryMuscles.Name = "colPrimaryMuscles";
            this.colPrimaryMuscles.ReadOnly = true;
            this.colPrimaryMuscles.Width = 157;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans HK", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "動作清單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans HK", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(815, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 46);
            this.label3.TabIndex = 18;
            this.label3.Text = "個人課表";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(704, 781);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "加入課表→";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(1134, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "刪除動作";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.btnUp.Location = new System.Drawing.Point(1281, 568);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(52, 34);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = "上移";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.Location = new System.Drawing.Point(1343, 568);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(52, 34);
            this.btnDown.TabIndex = 22;
            this.btnDown.Text = "下移";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "動作資料庫",
            "常用(需登入)"});
            this.cmbMode.Location = new System.Drawing.Point(156, 12);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(174, 32);
            this.cmbMode.TabIndex = 24;
            this.cmbMode.Text = "動作資料庫";
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // labPageSize
            // 
            this.labPageSize.AutoSize = true;
            this.labPageSize.Location = new System.Drawing.Point(133, 29);
            this.labPageSize.Name = "labPageSize";
            this.labPageSize.Size = new System.Drawing.Size(158, 24);
            this.labPageSize.TabIndex = 29;
            this.labPageSize.Text = "每頁                         筆";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.Items.AddRange(new object[] {
            "(全部)",
            "10",
            "20",
            "30",
            "40"});
            this.cmbPageSize.Location = new System.Drawing.Point(178, 25);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(85, 32);
            this.cmbPageSize.TabIndex = 30;
            this.cmbPageSize.Text = "10";
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbPageSize_SelectedIndexChanged);
            // 
            // btnLastPage
            // 
            this.btnLastPage.AutoSize = true;
            this.btnLastPage.Location = new System.Drawing.Point(558, 24);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(38, 34);
            this.btnLastPage.TabIndex = 32;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.AutoSize = true;
            this.btnPrevPage.Location = new System.Drawing.Point(383, 24);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(29, 34);
            this.btnPrevPage.TabIndex = 31;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.AutoSize = true;
            this.btnFirstPage.Location = new System.Drawing.Point(342, 24);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(38, 34);
            this.btnFirstPage.TabIndex = 33;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // cmbCurrentPage
            // 
            this.cmbCurrentPage.FormattingEnabled = true;
            this.cmbCurrentPage.Location = new System.Drawing.Point(446, 25);
            this.cmbCurrentPage.Name = "cmbCurrentPage";
            this.cmbCurrentPage.Size = new System.Drawing.Size(46, 32);
            this.cmbCurrentPage.TabIndex = 35;
            this.cmbCurrentPage.Text = "1";
            this.cmbCurrentPage.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentPage_SelectedIndexChanged);
            // 
            // labCurrentPage
            // 
            this.labCurrentPage.AutoSize = true;
            this.labCurrentPage.Location = new System.Drawing.Point(418, 29);
            this.labCurrentPage.Name = "labCurrentPage";
            this.labCurrentPage.Size = new System.Drawing.Size(102, 24);
            this.labCurrentPage.TabIndex = 34;
            this.labCurrentPage.Text = "第               頁";
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoSize = true;
            this.btnNextPage.Location = new System.Drawing.Point(523, 24);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(29, 34);
            this.btnNextPage.TabIndex = 36;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // labTotalCount
            // 
            this.labTotalCount.AutoSize = true;
            this.labTotalCount.Location = new System.Drawing.Point(20, 29);
            this.labTotalCount.Name = "labTotalCount";
            this.labTotalCount.Size = new System.Drawing.Size(69, 24);
            this.labTotalCount.TabIndex = 37;
            this.labTotalCount.Text = "共873筆";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 25;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.Title = "訓練強度";
            legend2.TitleFont = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-11, 593);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieDrawingStyle=SoftEdge";
            series2.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint4.LegendText = "Beginner";
            dataPoint5.LegendText = "Intermediate";
            dataPoint6.LegendText = "Expert";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(435, 384);
            this.chart1.TabIndex = 40;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAll);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbPageSize);
            this.panel2.Controls.Add(this.labTotalCount);
            this.panel2.Controls.Add(this.btnPrevPage);
            this.panel2.Controls.Add(this.btnNextPage);
            this.panel2.Controls.Add(this.btnLastPage);
            this.panel2.Controls.Add(this.cmbCurrentPage);
            this.panel2.Controls.Add(this.btnFirstPage);
            this.panel2.Controls.Add(this.labCurrentPage);
            this.panel2.Controls.Add(this.labPageSize);
            this.panel2.Location = new System.Drawing.Point(556, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 533);
            this.panel2.TabIndex = 41;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(12, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 34);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "切換使用者";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvManual
            // 
            this.dgvManual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvManual.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvManual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManual.ColumnHeadersHeight = 35;
            this.dgvManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col2ExerciseID,
            this.col2Name,
            this.col2ForceType,
            this.col2Level,
            this.col2Mechanic,
            this.col2Equipment,
            this.col2PrimaryMuscles,
            this.col2Category,
            this.col2AutoID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManual.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManual.Location = new System.Drawing.Point(810, 608);
            this.dgvManual.Name = "dgvManual";
            this.dgvManual.RowHeadersWidth = 25;
            this.dgvManual.RowTemplate.Height = 24;
            this.dgvManual.Size = new System.Drawing.Size(1010, 380);
            this.dgvManual.TabIndex = 43;
            this.dgvManual.SelectionChanged += new System.EventHandler(this.dgvManual_SelectionChanged);
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataMember = "Exercises";
            this.exercisesBindingSource.DataSource = this.ExerciseDataSet;
            // 
            // ExerciseDataSet
            // 
            this.ExerciseDataSet.DataSetName = "ExerciseDataSet";
            this.ExerciseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exercisesTableAdapter
            // 
            this.exercisesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExercisesTableAdapter = this.exercisesTableAdapter;
            this.tableAdapterManager.ManualTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinFrmApp_Workout.ExerciseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manualTableAdapter
            // 
            this.manualTableAdapter.ClearBeforeFill = true;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // picFinish
            // 
            this.picFinish.BackColor = System.Drawing.Color.White;
            this.picFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFinish.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picFinish.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picFinish.ErrorImage")));
            this.picFinish.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFinish.InitialImage")));
            this.picFinish.Location = new System.Drawing.Point(409, 798);
            this.picFinish.Name = "picFinish";
            this.picFinish.Size = new System.Drawing.Size(286, 190);
            this.picFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinish.TabIndex = 39;
            this.picFinish.TabStop = false;
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.White;
            this.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picStart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picStart.ErrorImage")));
            this.picStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picStart.InitialImage")));
            this.picStart.Location = new System.Drawing.Point(409, 608);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(286, 190);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStart.TabIndex = 14;
            this.picStart.TabStop = false;
            // 
            // col2ExerciseID
            // 
            this.col2ExerciseID.DataPropertyName = "ExerciseID";
            this.col2ExerciseID.HeaderText = "編號";
            this.col2ExerciseID.Name = "col2ExerciseID";
            this.col2ExerciseID.ReadOnly = true;
            this.col2ExerciseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2ExerciseID.Width = 50;
            // 
            // col2Name
            // 
            this.col2Name.DataPropertyName = "Name";
            this.col2Name.HeaderText = "Name";
            this.col2Name.Name = "col2Name";
            this.col2Name.ReadOnly = true;
            this.col2Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2Name.Width = 200;
            // 
            // col2ForceType
            // 
            this.col2ForceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2ForceType.DataPropertyName = "ForceType";
            this.col2ForceType.HeaderText = "Force Type";
            this.col2ForceType.Name = "col2ForceType";
            this.col2ForceType.ReadOnly = true;
            this.col2ForceType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2ForceType.Width = 98;
            // 
            // col2Level
            // 
            this.col2Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2Level.DataPropertyName = "Level";
            this.col2Level.HeaderText = "Level";
            this.col2Level.Name = "col2Level";
            this.col2Level.ReadOnly = true;
            this.col2Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2Level.Width = 56;
            // 
            // col2Mechanic
            // 
            this.col2Mechanic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2Mechanic.DataPropertyName = "Mechanic";
            this.col2Mechanic.HeaderText = "Mechanic";
            this.col2Mechanic.Name = "col2Mechanic";
            this.col2Mechanic.ReadOnly = true;
            this.col2Mechanic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2Mechanic.Width = 87;
            // 
            // col2Equipment
            // 
            this.col2Equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2Equipment.DataPropertyName = "Equipment";
            this.col2Equipment.HeaderText = "Equipment";
            this.col2Equipment.Name = "col2Equipment";
            this.col2Equipment.ReadOnly = true;
            this.col2Equipment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2Equipment.Width = 99;
            // 
            // col2PrimaryMuscles
            // 
            this.col2PrimaryMuscles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2PrimaryMuscles.DataPropertyName = "PrimaryMuscles";
            this.col2PrimaryMuscles.HeaderText = "Primary Muscles";
            this.col2PrimaryMuscles.Name = "col2PrimaryMuscles";
            this.col2PrimaryMuscles.ReadOnly = true;
            this.col2PrimaryMuscles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2PrimaryMuscles.Width = 138;
            // 
            // col2Category
            // 
            this.col2Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col2Category.DataPropertyName = "Category";
            this.col2Category.HeaderText = "Category";
            this.col2Category.Name = "col2Category";
            this.col2Category.ReadOnly = true;
            this.col2Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2Category.Width = 84;
            // 
            // col2AutoID
            // 
            this.col2AutoID.DataPropertyName = "AutoID";
            this.col2AutoID.HeaderText = "AutoID";
            this.col2AutoID.Name = "col2AutoID";
            this.col2AutoID.ReadOnly = true;
            this.col2AutoID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col2AutoID.Visible = false;
            // 
            // Frm02_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1904, 1008);
            this.Controls.Add(this.picFinish);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvManual);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm02_Main";
            this.Text = "健身動作查詢系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm02_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHuman;
        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnBicep;
        private System.Windows.Forms.Button btnForearm;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnQuad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGlute;
        private System.Windows.Forms.Button btnHam;
        private System.Windows.Forms.Button btnCalf;
        private System.Windows.Forms.Button btnShoulder;
        private System.Windows.Forms.Button btnTricep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label labPageSize;
        private System.Windows.Forms.ComboBox cmbPageSize;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.ComboBox cmbCurrentPage;
        private System.Windows.Forms.Label labCurrentPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labTotalCount;
        private System.Windows.Forms.PictureBox picFinish;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ExerciseDataSet ExerciseDataSet;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private ExerciseDataSetTableAdapters.ExercisesTableAdapter exercisesTableAdapter;
        private ExerciseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNeck;
        private System.Windows.Forms.Button btnAbd;
        private System.Windows.Forms.Button btnAdductor;
        private ExerciseDataSetTableAdapters.ManualTableAdapter manualTableAdapter;
        private ExerciseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridView dgvManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFavorite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExerciseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimaryMuscles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2ExerciseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2ForceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Mechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2PrimaryMuscles;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2AutoID;
    }
}