namespace Socket
{
    partial class LoginWindow
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
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.NickLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.NickTxt = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(37, 64);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Password:";
            // 
            // NickLbl
            // 
            this.NickLbl.AutoSize = true;
            this.NickLbl.Location = new System.Drawing.Point(37, 38);
            this.NickLbl.Name = "NickLbl";
            this.NickLbl.Size = new System.Drawing.Size(32, 13);
            this.NickLbl.TabIndex = 6;
            this.NickLbl.Text = "Nick:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxt.Location = new System.Drawing.Point(99, 61);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 5;
            // 
            // NickTxt
            // 
            this.NickTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickTxt.Location = new System.Drawing.Point(99, 35);
            this.NickTxt.Name = "NickTxt";
            this.NickTxt.Size = new System.Drawing.Size(100, 20);
            this.NickTxt.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.LightGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(214, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.LightGray;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Location = new System.Drawing.Point(40, 95);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightGray;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(124, 95);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 140);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.NickLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.NickTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label NickLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox NickTxt;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}