namespace WinFrmApp_Workout
{
    partial class Frm3_CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManul = new System.Windows.Forms.DataGridView();
            this.labAction = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.labPart = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManul)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans HK", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(115, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "自訂的動作清單";
            // 
            // dgvManul
            // 
            this.dgvManul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManul.Location = new System.Drawing.Point(12, 12);
            this.dgvManul.Name = "dgvManul";
            this.dgvManul.RowTemplate.Height = 24;
            this.dgvManul.Size = new System.Drawing.Size(485, 320);
            this.dgvManul.TabIndex = 16;
            // 
            // labAction
            // 
            this.labAction.AutoSize = true;
            this.labAction.Location = new System.Drawing.Point(570, 87);
            this.labAction.Name = "labAction";
            this.labAction.Size = new System.Drawing.Size(90, 24);
            this.labAction.TabIndex = 18;
            this.labAction.Text = "動作名稱：";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(650, 84);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(100, 31);
            this.txtAction.TabIndex = 19;
            // 
            // labPart
            // 
            this.labPart.AutoSize = true;
            this.labPart.Location = new System.Drawing.Point(570, 147);
            this.labPart.Name = "labPart";
            this.labPart.Size = new System.Drawing.Size(90, 24);
            this.labPart.TabIndex = 20;
            this.labPart.Text = "訓練部位：";
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(650, 144);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(121, 32);
            this.cmbPart.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(577, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(658, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(739, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Location = new System.Drawing.Point(574, 196);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 34);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "插入圖片";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans HK", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(197, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "ForceType, Level, Mechanic, Equipment, Category";
            // 
            // Frm3_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.labPart);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.labAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManul);
            this.Font = new System.Drawing.Font("Noto Sans HK", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm3_CRUD";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManul;
        private System.Windows.Forms.Label labAction;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label labPart;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
    }
}