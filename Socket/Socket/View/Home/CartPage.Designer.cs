namespace Socket.View.Home
{
    partial class CartPage
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
            this.TabPage2Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TabPage2Lbl
            // 
            this.TabPage2Lbl.AutoSize = true;
            this.TabPage2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPage2Lbl.Location = new System.Drawing.Point(3, 0);
            this.TabPage2Lbl.Name = "TabPage2Lbl";
            this.TabPage2Lbl.Size = new System.Drawing.Size(141, 31);
            this.TabPage2Lbl.TabIndex = 1;
            this.TabPage2Lbl.Text = "Curt page.";
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabPage2Lbl);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(433, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TabPage2Lbl;
    }
}
