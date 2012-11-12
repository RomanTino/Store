namespace Socket.BLL.View.Home
{
    partial class AddToCartMessageBox
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
            this.TextLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLbl.Location = new System.Drawing.Point(66, 49);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(150, 20);
            this.TextLbl.TabIndex = 0;
            this.TextLbl.Text = "Successfully added!";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightGray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(244, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 30);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddToCartMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 109);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.TextLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddToCartMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCartMessageBox";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToCartMessageBox_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddToCartMessageBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddToCartMessageBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddToCartMessageBox_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}