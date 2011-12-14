namespace FormHost
{
    partial class FormHost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.pcbTCP = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pcbWS = new System.Windows.Forms.PictureBox();
            this.pcbBS = new System.Windows.Forms.PictureBox();
            this.pcbMEX = new System.Windows.Forms.PictureBox();
            this.cbTCPNET = new System.Windows.Forms.CheckBox();
            this.cbWSHTTP = new System.Windows.Forms.CheckBox();
            this.cbMEX = new System.Windows.Forms.CheckBox();
            this.cbBSHTTP = new System.Windows.Forms.CheckBox();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnChuXe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTKhoan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMEX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.pcbTCP);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.pcbWS);
            this.groupBox1.Controls.Add(this.pcbBS);
            this.groupBox1.Controls.Add(this.pcbMEX);
            this.groupBox1.Controls.Add(this.cbTCPNET);
            this.groupBox1.Controls.Add(this.cbWSHTTP);
            this.groupBox1.Controls.Add(this.cbMEX);
            this.groupBox1.Controls.Add(this.cbBSHTTP);
            this.groupBox1.Controls.Add(this.txtBaseAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Service";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Maroon;
            this.btnStop.Location = new System.Drawing.Point(175, 178);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP HOSTING";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pcbTCP
            // 
            this.pcbTCP.Location = new System.Drawing.Point(245, 140);
            this.pcbTCP.Name = "pcbTCP";
            this.pcbTCP.Size = new System.Drawing.Size(21, 20);
            this.pcbTCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTCP.TabIndex = 4;
            this.pcbTCP.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(19, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START HOSTING";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pcbWS
            // 
            this.pcbWS.Location = new System.Drawing.Point(245, 114);
            this.pcbWS.Name = "pcbWS";
            this.pcbWS.Size = new System.Drawing.Size(21, 20);
            this.pcbWS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWS.TabIndex = 4;
            this.pcbWS.TabStop = false;
            // 
            // pcbBS
            // 
            this.pcbBS.Location = new System.Drawing.Point(245, 88);
            this.pcbBS.Name = "pcbBS";
            this.pcbBS.Size = new System.Drawing.Size(21, 20);
            this.pcbBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBS.TabIndex = 4;
            this.pcbBS.TabStop = false;
            // 
            // pcbMEX
            // 
            this.pcbMEX.Location = new System.Drawing.Point(245, 62);
            this.pcbMEX.Name = "pcbMEX";
            this.pcbMEX.Size = new System.Drawing.Size(21, 20);
            this.pcbMEX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMEX.TabIndex = 4;
            this.pcbMEX.TabStop = false;
            // 
            // cbTCPNET
            // 
            this.cbTCPNET.AutoSize = true;
            this.cbTCPNET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTCPNET.Location = new System.Drawing.Point(37, 143);
            this.cbTCPNET.Name = "cbTCPNET";
            this.cbTCPNET.Size = new System.Drawing.Size(85, 20);
            this.cbTCPNET.TabIndex = 3;
            this.cbTCPNET.Text = "TCP.NET";
            this.cbTCPNET.UseVisualStyleBackColor = true;
            this.cbTCPNET.Click += new System.EventHandler(this.cbTCPNET_Click);
            // 
            // cbWSHTTP
            // 
            this.cbWSHTTP.AutoSize = true;
            this.cbWSHTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWSHTTP.Location = new System.Drawing.Point(37, 117);
            this.cbWSHTTP.Name = "cbWSHTTP";
            this.cbWSHTTP.Size = new System.Drawing.Size(86, 20);
            this.cbWSHTTP.TabIndex = 3;
            this.cbWSHTTP.Text = "WSHTTP";
            this.cbWSHTTP.UseVisualStyleBackColor = true;
            this.cbWSHTTP.Click += new System.EventHandler(this.cbWSHTTP_Click);
            // 
            // cbMEX
            // 
            this.cbMEX.AutoSize = true;
            this.cbMEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMEX.Location = new System.Drawing.Point(37, 65);
            this.cbMEX.Name = "cbMEX";
            this.cbMEX.Size = new System.Drawing.Size(55, 20);
            this.cbMEX.TabIndex = 3;
            this.cbMEX.Text = "MEX";
            this.cbMEX.UseVisualStyleBackColor = true;
            this.cbMEX.Click += new System.EventHandler(this.cbMEX_Click);
            // 
            // cbBSHTTP
            // 
            this.cbBSHTTP.AutoSize = true;
            this.cbBSHTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBSHTTP.Location = new System.Drawing.Point(37, 91);
            this.cbBSHTTP.Name = "cbBSHTTP";
            this.cbBSHTTP.Size = new System.Drawing.Size(101, 20);
            this.cbBSHTTP.TabIndex = 3;
            this.cbBSHTTP.Text = "Basic HTTP";
            this.cbBSHTTP.UseVisualStyleBackColor = true;
            this.cbBSHTTP.Click += new System.EventHandler(this.cbBSHTTP_Click);
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(116, 23);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(200, 24);
            this.txtBaseAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Address";
            // 
            // btnXe
            // 
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXe.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnXe.Location = new System.Drawing.Point(368, 20);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(150, 36);
            this.btnXe.TabIndex = 1;
            this.btnXe.Text = "Danh Mục Xe";
            this.btnXe.UseVisualStyleBackColor = true;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnChuXe
            // 
            this.btnChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuXe.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnChuXe.Location = new System.Drawing.Point(368, 77);
            this.btnChuXe.Name = "btnChuXe";
            this.btnChuXe.Size = new System.Drawing.Size(150, 36);
            this.btnChuXe.TabIndex = 1;
            this.btnChuXe.Text = "Danh Mục Chủ Xe";
            this.btnChuXe.UseVisualStyleBackColor = true;
            this.btnChuXe.Click += new System.EventHandler(this.btnChuXe_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDong.Location = new System.Drawing.Point(368, 205);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 36);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTKhoan
            // 
            this.btnTKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKhoan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTKhoan.Location = new System.Drawing.Point(368, 135);
            this.btnTKhoan.Name = "btnTKhoan";
            this.btnTKhoan.Size = new System.Drawing.Size(150, 36);
            this.btnTKhoan.TabIndex = 1;
            this.btnTKhoan.Text = "Tạo Tài Khoản Admin";
            this.btnTKhoan.UseVisualStyleBackColor = true;
            this.btnTKhoan.Click += new System.EventHandler(this.btnTKhoan_Click);
            // 
            // FormHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 252);
            this.Controls.Add(this.btnTKhoan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChuXe);
            this.Controls.Add(this.btnXe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM HOST SERVICE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMEX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTCPNET;
        private System.Windows.Forms.CheckBox cbWSHTTP;
        private System.Windows.Forms.CheckBox cbMEX;
        private System.Windows.Forms.CheckBox cbBSHTTP;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pcbTCP;
        private System.Windows.Forms.PictureBox pcbWS;
        private System.Windows.Forms.PictureBox pcbBS;
        private System.Windows.Forms.PictureBox pcbMEX;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnChuXe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTKhoan;
    }
}

