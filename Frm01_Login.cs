using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFrmApp_Workout
{
    public partial class Frm01_Login : Form
    {
        public Frm01_Login()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ExerciseDB.mdf;Integrated Security=True;Connect Timeout=30";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("請輸入帳號密碼", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string account = txtAccount.Text;
                string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");

                conn.Open();
                SqlCommand command = new SqlCommand(@"SELECT * FROM Members WHERE Account = @account AND Password = @password", conn);
                command.Parameters.AddWithValue("@account", account);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    // 從Frm2取得登入
                    if (this.Modal)
                    {
                        this.Tag = account;
                        this.DialogResult = DialogResult.OK;
                    }
                    else // 從Frm1登入
                    {
                        new Frm02_Main(true, account).Show();
                    }
                }
                else
                {
                    MessageBox.Show("登入失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("請輸入帳號密碼");
                return;
            }
            using (SqlConnection conn = new SqlConnection(this.membersTableAdapter.Connection.ConnectionString))
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM Members WHERE Account = @acc";

                using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                {   
                    //檢查帳號是否已存在
                    checkCmd.Parameters.AddWithValue("@acc", txtAccount.Text);
                    int count = (int)checkCmd.ExecuteScalar(); 
                    if (count > 0)
                    {
                        MessageBox.Show("此帳號已存在");
                        return;
                    }
                }
            }
            // 密碼加密
            string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "sha1");
            membersTableAdapter.Insert(txtAccount.Text, password);

            MessageBox.Show("建立成功！");
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                new Frm02_Main(false, null).Show();
            }
        }
    }
}
