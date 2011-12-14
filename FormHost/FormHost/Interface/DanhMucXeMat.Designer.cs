namespace FormHost.Interface
{
    partial class DanhMucXeMat
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
            this.cbDaTimThay = new System.Windows.Forms.CheckBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.cbChuaTimThay = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTatCa = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoBienSo = new System.Windows.Forms.Button();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoCMND = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDaTimThay
            // 
            this.cbDaTimThay.AutoSize = true;
            this.cbDaTimThay.Location = new System.Drawing.Point(6, 96);
            this.cbDaTimThay.Name = "cbDaTimThay";
            this.cbDaTimThay.Size = new System.Drawing.Size(113, 19);
            this.cbDaTimThay.TabIndex = 3;
            this.cbDaTimThay.Text = "Xe Đã Tìm Thấy";
            this.cbDaTimThay.UseVisualStyleBackColor = true;
            this.cbDaTimThay.Click += new System.EventHandler(this.cbDaTimThay_Click);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(177, 80);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(610, 315);
            this.GridView.TabIndex = 5;
            // 
            // cbChuaTimThay
            // 
            this.cbChuaTimThay.AutoSize = true;
            this.cbChuaTimThay.Location = new System.Drawing.Point(6, 63);
            this.cbChuaTimThay.Name = "cbChuaTimThay";
            this.cbChuaTimThay.Size = new System.Drawing.Size(126, 19);
            this.cbChuaTimThay.TabIndex = 2;
            this.cbChuaTimThay.Text = "Xe Chưa Tìm Thấy";
            this.cbChuaTimThay.UseVisualStyleBackColor = true;
            this.cbChuaTimThay.Click += new System.EventHandler(this.cbChuaTimThay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDaTimThay);
            this.groupBox1.Controls.Add(this.cbChuaTimThay);
            this.groupBox1.Controls.Add(this.cbTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lọc";
            // 
            // cbTatCa
            // 
            this.cbTatCa.AutoSize = true;
            this.cbTatCa.Location = new System.Drawing.Point(6, 30);
            this.cbTatCa.Name = "cbTatCa";
            this.cbTatCa.Size = new System.Drawing.Size(79, 19);
            this.cbTatCa.TabIndex = 1;
            this.cbTatCa.Text = "Tất Cả Xe";
            this.cbTatCa.UseVisualStyleBackColor = true;
            this.cbTatCa.Click += new System.EventHandler(this.cbTatCa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTheoBienSo);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo Biển Số";
            // 
            // btnTimTheoBienSo
            // 
            this.btnTimTheoBienSo.Location = new System.Drawing.Point(7, 50);
            this.btnTimTheoBienSo.Name = "btnTimTheoBienSo";
            this.btnTimTheoBienSo.Size = new System.Drawing.Size(146, 23);
            this.btnTimTheoBienSo.TabIndex = 1;
            this.btnTimTheoBienSo.Text = "Tìm";
            this.btnTimTheoBienSo.UseVisualStyleBackColor = true;
            this.btnTimTheoBienSo.Click += new System.EventHandler(this.btnTimTheoBienSo_Click);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(7, 22);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(146, 21);
            this.txtBienSo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimTheoCMND);
            this.groupBox3.Controls.Add(this.txtCMND);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo CMND";
            // 
            // btnTimTheoCMND
            // 
            this.btnTimTheoCMND.Location = new System.Drawing.Point(7, 50);
            this.btnTimTheoCMND.Name = "btnTimTheoCMND";
            this.btnTimTheoCMND.Size = new System.Drawing.Size(146, 23);
            this.btnTimTheoCMND.TabIndex = 1;
            this.btnTimTheoCMND.Text = "Tìm";
            this.btnTimTheoCMND.UseVisualStyleBackColor = true;
            this.btnTimTheoCMND.Click += new System.EventHandler(this.btnTimTheoCMND_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(7, 22);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(146, 21);
            this.txtCMND.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(440, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(346, 41);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE INFORMATION";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCheck.Location = new System.Drawing.Point(177, 22);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(257, 41);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Đã Tìm Thấy";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DanhMucXeMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhMucXeMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục xe mất";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDaTimThay;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.CheckBox cbChuaTimThay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTheoBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimTheoCMND;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}