namespace Socket
{
    partial class RegistrationWindow
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.NickTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NickLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.RegistrBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfPassLbl = new System.Windows.Forms.Label();
            this.ConfPassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.LightGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(275, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(89, 34);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 10;
            this.NameLbl.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Location = new System.Drawing.Point(137, 32);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 11;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameTxt.Location = new System.Drawing.Point(137, 58);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(100, 20);
            this.SurnameTxt.TabIndex = 12;
            // 
            // NickTxt
            // 
            this.NickTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickTxt.Location = new System.Drawing.Point(137, 84);
            this.NickTxt.Name = "NickTxt";
            this.NickTxt.Size = new System.Drawing.Size(100, 20);
            this.NickTxt.TabIndex = 13;
            // 
            // PassTxt
            // 
            this.PassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTxt.Location = new System.Drawing.Point(137, 111);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(100, 20);
            this.PassTxt.TabIndex = 14;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(75, 60);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(52, 13);
            this.SurnameLbl.TabIndex = 15;
            this.SurnameLbl.Text = "Surname:";
            // 
            // NickLbl
            // 
            this.NickLbl.AutoSize = true;
            this.NickLbl.Location = new System.Drawing.Point(95, 86);
            this.NickLbl.Name = "NickLbl";
            this.NickLbl.Size = new System.Drawing.Size(32, 13);
            this.NickLbl.TabIndex = 16;
            this.NickLbl.Text = "Nick:";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(71, 113);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(56, 13);
            this.PassLbl.TabIndex = 17;
            this.PassLbl.Text = "Password:";
            // 
            // RegistrBtn
            // 
            this.RegistrBtn.BackColor = System.Drawing.Color.LightGray;
            this.RegistrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrBtn.Location = new System.Drawing.Point(45, 194);
            this.RegistrBtn.Name = "RegistrBtn";
            this.RegistrBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistrBtn.TabIndex = 18;
            this.RegistrBtn.Text = "Register";
            this.RegistrBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightGray;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(162, 194);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CanselBtn_Click);
            // 
            // ConfPassLbl
            // 
            this.ConfPassLbl.AutoSize = true;
            this.ConfPassLbl.Location = new System.Drawing.Point(33, 139);
            this.ConfPassLbl.Name = "ConfPassLbl";
            this.ConfPassLbl.Size = new System.Drawing.Size(94, 13);
            this.ConfPassLbl.TabIndex = 20;
            this.ConfPassLbl.Text = "Confirm Password:";
            // 
            // ConfPassTxt
            // 
            this.ConfPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfPassTxt.Location = new System.Drawing.Point(137, 137);
            this.ConfPassTxt.Name = "ConfPassTxt";
            this.ConfPassTxt.Size = new System.Drawing.Size(100, 20);
            this.ConfPassTxt.TabIndex = 21;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(309, 236);
            this.Controls.Add(this.ConfPassTxt);
            this.Controls.Add(this.ConfPassLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RegistrBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.NickLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.NickTxt);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegistrationWindow_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.TextBox NickTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NickLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button RegistrBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label ConfPassLbl;
        private System.Windows.Forms.TextBox ConfPassTxt;

    }
}