namespace FormClient
{
    partial class MainForm
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
            this.ptbSign = new System.Windows.Forms.PictureBox();
            this.rbtnTCPNET = new System.Windows.Forms.RadioButton();
            this.rbtnWSHTTP = new System.Windows.Forms.RadioButton();
            this.rbtnBSHTTP = new System.Windows.Forms.RadioButton();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoMat = new System.Windows.Forms.Button();
            this.btnTKhoan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSign)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbSign);
            this.groupBox1.Controls.Add(this.rbtnTCPNET);
            this.groupBox1.Controls.Add(this.rbtnWSHTTP);
            this.groupBox1.Controls.Add(this.rbtnBSHTTP);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtBaseAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // ptbSign
            // 
            this.ptbSign.Location = new System.Drawing.Point(63, 169);
            this.ptbSign.Name = "ptbSign";
            this.ptbSign.Size = new System.Drawing.Size(100, 100);
            this.ptbSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSign.TabIndex = 7;
            this.ptbSign.TabStop = false;
            // 
            // rbtnTCPNET
            // 
            this.rbtnTCPNET.AutoSize = true;
            this.rbtnTCPNET.Location = new System.Drawing.Point(17, 113);
            this.rbtnTCPNET.Name = "rbtnTCPNET";
            this.rbtnTCPNET.Size = new System.Drawing.Size(68, 17);
            this.rbtnTCPNET.TabIndex = 6;
            this.rbtnTCPNET.TabStop = true;
            this.rbtnTCPNET.Text = "TCPNET";
            this.rbtnTCPNET.UseVisualStyleBackColor = true;
            this.rbtnTCPNET.Click += new System.EventHandler(this.rbtnTCPNET_Click);
            // 
            // rbtnWSHTTP
            // 
            this.rbtnWSHTTP.AutoSize = true;
            this.rbtnWSHTTP.Location = new System.Drawing.Point(17, 90);
            this.rbtnWSHTTP.Name = "rbtnWSHTTP";
            this.rbtnWSHTTP.Size = new System.Drawing.Size(75, 17);
            this.rbtnWSHTTP.TabIndex = 5;
            this.rbtnWSHTTP.TabStop = true;
            this.rbtnWSHTTP.Text = "WS HTTP";
            this.rbtnWSHTTP.UseVisualStyleBackColor = true;
            this.rbtnWSHTTP.Click += new System.EventHandler(this.rbtnWSHTTP_Click);
            // 
            // rbtnBSHTTP
            // 
            this.rbtnBSHTTP.AutoSize = true;
            this.rbtnBSHTTP.Location = new System.Drawing.Point(17, 67);
            this.rbtnBSHTTP.Name = "rbtnBSHTTP";
            this.rbtnBSHTTP.Size = new System.Drawing.Size(88, 17);
            this.rbtnBSHTTP.TabIndex = 4;
            this.rbtnBSHTTP.TabStop = true;
            this.rbtnBSHTTP.Text = "BASIC HTTP";
            this.rbtnBSHTTP.UseVisualStyleBackColor = true;
            this.rbtnBSHTTP.Click += new System.EventHandler(this.rbtnBSHTTP_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Maroon;
            this.btnDisconnect.Location = new System.Drawing.Point(123, 136);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 27);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Maroon;
            this.btnConnect.Location = new System.Drawing.Point(17, 136);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 27);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(17, 40);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(200, 20);
            this.txtBaseAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base Address";
            // 
            // btnBaoMat
            // 
            this.btnBaoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoMat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnBaoMat.Location = new System.Drawing.Point(255, 20);
            this.btnBaoMat.Name = "btnBaoMat";
            this.btnBaoMat.Size = new System.Drawing.Size(150, 40);
            this.btnBaoMat.TabIndex = 1;
            this.btnBaoMat.Text = "Báo Mất Xe";
            this.btnBaoMat.UseVisualStyleBackColor = true;
            this.btnBaoMat.Click += new System.EventHandler(this.btnBaoMat_Click);
            // 
            // btnTKhoan
            // 
            this.btnTKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKhoan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTKhoan.Location = new System.Drawing.Point(255, 68);
            this.btnTKhoan.Name = "btnTKhoan";
            this.btnTKhoan.Size = new System.Drawing.Size(150, 40);
            this.btnTKhoan.TabIndex = 1;
            this.btnTKhoan.Text = "Kiểm Tra Xe Đã Báo";
            this.btnTKhoan.UseVisualStyleBackColor = true;
            this.btnTKhoan.Click += new System.EventHandler(this.btnTKhoan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDong.Location = new System.Drawing.Point(255, 259);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 308);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTKhoan);
            this.Controls.Add(this.btnBaoMat);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM CLIENT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTCPNET;
        private System.Windows.Forms.RadioButton rbtnWSHTTP;
        private System.Windows.Forms.RadioButton rbtnBSHTTP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.PictureBox ptbSign;
        private System.Windows.Forms.Button btnBaoMat;
        private System.Windows.Forms.Button btnTKhoan;
        private System.Windows.Forms.Button btnDong;
    }
}

