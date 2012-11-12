namespace Socket.View.Home
{
    partial class UserPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPage3Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TabPage3Lbl
            // 
            this.TabPage3Lbl.AutoSize = true;
            this.TabPage3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPage3Lbl.Location = new System.Drawing.Point(3, 0);
            this.TabPage3Lbl.Name = "TabPage3Lbl";
            this.TabPage3Lbl.Size = new System.Drawing.Size(147, 31);
            this.TabPage3Lbl.TabIndex = 1;
            this.TabPage3Lbl.Text = "User page.";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabPage3Lbl);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(353, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TabPage3Lbl;

    }
}
