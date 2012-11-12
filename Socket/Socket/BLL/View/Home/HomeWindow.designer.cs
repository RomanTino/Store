namespace Socket
{
    public partial class HomeWindow
    {
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TabControl hometabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel hidePnl;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Button tabPage1Btn;
        private System.Windows.Forms.Button tabPage2Btn;
        private System.Windows.Forms.Button tabPage3Btn;
        private System.Windows.Forms.Button tabPage4Btn;
        private System.Windows.Forms.Panel buttonPnl;
        private System.Windows.Forms.Button registerBtn;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.hometabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.hidePnl = new System.Windows.Forms.Panel();
            this.topPnl = new System.Windows.Forms.Panel();
            this.tabPage1Btn = new System.Windows.Forms.Button();
            this.tabPage2Btn = new System.Windows.Forms.Button();
            this.tabPage3Btn = new System.Windows.Forms.Button();
            this.tabPage4Btn = new System.Windows.Forms.Button();
            this.buttonPnl = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.hometabCtrl.SuspendLayout();
            this.topPnl.SuspendLayout();
            this.buttonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightGray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(1328, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 30);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.LightGray;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeBtn.Location = new System.Drawing.Point(1292, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightGray;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(1290, 49);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // hometabCtrl
            // 
            this.hometabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hometabCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.hometabCtrl.Controls.Add(this.tabPage1);
            this.hometabCtrl.Controls.Add(this.tabPage2);
            this.hometabCtrl.Controls.Add(this.tabPage3);
            this.hometabCtrl.Controls.Add(this.tabPage4);
            this.hometabCtrl.Location = new System.Drawing.Point(12, 67);
            this.hometabCtrl.Name = "hometabCtrl";
            this.hometabCtrl.SelectedIndex = 0;
            this.hometabCtrl.Size = new System.Drawing.Size(986, 656);
            this.hometabCtrl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(978, 627);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(978, 627);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(978, 627);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            // 
            // hidePnl
            // 
            this.hidePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hidePnl.Location = new System.Drawing.Point(12, 58);
            this.hidePnl.Name = "hidePnl";
            this.hidePnl.Size = new System.Drawing.Size(986, 31);
            this.hidePnl.TabIndex = 4;
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.White;
            this.topPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPnl.Controls.Add(this.LogoPB);
            this.topPnl.Controls.Add(this.minimizeBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Location = new System.Drawing.Point(2, 1);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1363, 38);
            this.topPnl.TabIndex = 5;
            // 
            // tabPage1Btn
            // 
            this.tabPage1Btn.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabPage1Btn.Location = new System.Drawing.Point(18, 20);
            this.tabPage1Btn.Name = "tabPage1Btn";
            this.tabPage1Btn.Size = new System.Drawing.Size(75, 23);
            this.tabPage1Btn.TabIndex = 0;
            this.tabPage1Btn.Text = "Store";
            this.tabPage1Btn.UseVisualStyleBackColor = false;
            this.tabPage1Btn.Click += new System.EventHandler(this.TabPage1Btn_Click);
            // 
            // tabPage2Btn
            // 
            this.tabPage2Btn.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabPage2Btn.Location = new System.Drawing.Point(18, 62);
            this.tabPage2Btn.Name = "tabPage2Btn";
            this.tabPage2Btn.Size = new System.Drawing.Size(75, 23);
            this.tabPage2Btn.TabIndex = 7;
            this.tabPage2Btn.Text = "Cart";
            this.tabPage2Btn.UseVisualStyleBackColor = false;
            this.tabPage2Btn.Click += new System.EventHandler(this.TabPage2Btn_Click);
            // 
            // tabPage3Btn
            // 
            this.tabPage3Btn.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabPage3Btn.Location = new System.Drawing.Point(18, 100);
            this.tabPage3Btn.Name = "tabPage3Btn";
            this.tabPage3Btn.Size = new System.Drawing.Size(75, 23);
            this.tabPage3Btn.TabIndex = 8;
            this.tabPage3Btn.Text = "User";
            this.tabPage3Btn.UseVisualStyleBackColor = false;
            this.tabPage3Btn.Click += new System.EventHandler(this.TabPage3Btn_Click);
            // 
            // tabPage4Btn
            // 
            this.tabPage4Btn.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabPage4Btn.Location = new System.Drawing.Point(18, 140);
            this.tabPage4Btn.Name = "tabPage4Btn";
            this.tabPage4Btn.Size = new System.Drawing.Size(75, 23);
            this.tabPage4Btn.TabIndex = 9;
            this.tabPage4Btn.Text = "Admin";
            this.tabPage4Btn.UseVisualStyleBackColor = false;
            this.tabPage4Btn.Click += new System.EventHandler(this.TabPage4Btn_Click);
            // 
            // buttonPnl
            // 
            this.buttonPnl.BackColor = System.Drawing.Color.White;
            this.buttonPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonPnl.Controls.Add(this.tabPage3Btn);
            this.buttonPnl.Controls.Add(this.tabPage4Btn);
            this.buttonPnl.Controls.Add(this.tabPage1Btn);
            this.buttonPnl.Controls.Add(this.tabPage2Btn);
            this.buttonPnl.Location = new System.Drawing.Point(1004, 92);
            this.buttonPnl.Name = "buttonPnl";
            this.buttonPnl.Size = new System.Drawing.Size(117, 186);
            this.buttonPnl.TabIndex = 10;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightGray;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Location = new System.Drawing.Point(1209, 49);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LogoPB
            // 
            this.LogoPB.Image = global::Socket.Properties.Resources.Logo;
            this.LogoPB.Location = new System.Drawing.Point(592, -1);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(151, 38);
            this.LogoPB.TabIndex = 1;
            this.LogoPB.TabStop = false;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.buttonPnl);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.hidePnl);
            this.Controls.Add(this.hometabCtrl);
            this.Controls.Add(this.loginBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.hometabCtrl.ResumeLayout(false);
            this.topPnl.ResumeLayout(false);
            this.buttonPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPB;

    }
}
