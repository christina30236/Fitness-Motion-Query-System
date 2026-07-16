namespace WinFrmApp_Workout
{
    partial class Frm01_Login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm01_Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labAccount = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGuest = new System.Windows.Forms.Button();
            this.membersTableAdapter = new WinFrmApp_Workout.ExerciseDataSetTableAdapters.MembersTableAdapter();
            this.exerciseDataSet = new WinFrmApp_Workout.ExerciseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Location = new System.Drawing.Point(214, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "會員登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(88, 230);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 34);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "建立會員";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Location = new System.Drawing.Point(86, 117);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(58, 24);
            this.labAccount.TabIndex = 2;
            this.labAccount.Text = "帳號：";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(86, 165);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(58, 24);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "密碼：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(139, 114);
            this.txtAccount.MaxLength = 30;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(146, 31);
            this.txtAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 162);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 31);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnGuest
            // 
            this.btnGuest.AutoSize = true;
            this.btnGuest.Location = new System.Drawing.Point(124, 285);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(132, 34);
            this.btnGuest.TabIndex = 6;
            this.btnGuest.Text = "以訪客身分繼續";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // exerciseDataSet
            // 
            this.exerciseDataSet.DataSetName = "ExerciseDataSet";
            this.exerciseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans HK", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "健身動作查詢系統";
            // 
            // Frm01_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(396, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Noto Sans HK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm01_Login";
            this.Text = "健身動作查詢系統 | 登入";
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGuest;
        private ExerciseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private ExerciseDataSet exerciseDataSet;
        private System.Windows.Forms.Label label1;
    }
}

