namespace Socket
{
    partial class BuyingWindow
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
            this.BuyBtn = new System.Windows.Forms.Button();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.CodeLbl = new System.Windows.Forms.Label();
            this.NumberTxt = new System.Windows.Forms.TextBox();
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.MonthTxt = new System.Windows.Forms.TextBox();
            this.YearLbl = new System.Windows.Forms.Label();
            this.MonthLbl = new System.Windows.Forms.Label();
            this.betterSplitButton1 = new ComponentOwl.BetterSplitButton.BetterSplitButton();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.LightGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(251, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.LightGray;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Location = new System.Drawing.Point(112, 216);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(75, 23);
            this.BuyBtn.TabIndex = 11;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = false;
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Location = new System.Drawing.Point(48, 49);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(47, 13);
            this.NumberLbl.TabIndex = 13;
            this.NumberLbl.Text = "Number:";
            // 
            // CodeLbl
            // 
            this.CodeLbl.AutoSize = true;
            this.CodeLbl.Location = new System.Drawing.Point(60, 75);
            this.CodeLbl.Name = "CodeLbl";
            this.CodeLbl.Size = new System.Drawing.Size(35, 13);
            this.CodeLbl.TabIndex = 14;
            this.CodeLbl.Text = "Code:";
            // 
            // NumberTxt
            // 
            this.NumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberTxt.Location = new System.Drawing.Point(101, 47);
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(100, 20);
            this.NumberTxt.TabIndex = 16;
            // 
            // CodeTxt
            // 
            this.CodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeTxt.Location = new System.Drawing.Point(101, 73);
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(100, 20);
            this.CodeTxt.TabIndex = 17;
            // 
            // YearTxt
            // 
            this.YearTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTxt.Location = new System.Drawing.Point(101, 100);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(100, 20);
            this.YearTxt.TabIndex = 18;
            // 
            // MonthTxt
            // 
            this.MonthTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthTxt.Location = new System.Drawing.Point(101, 127);
            this.MonthTxt.Name = "MonthTxt";
            this.MonthTxt.Size = new System.Drawing.Size(100, 20);
            this.MonthTxt.TabIndex = 19;
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(63, 102);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(32, 13);
            this.YearLbl.TabIndex = 20;
            this.YearLbl.Text = "Year:";
            // 
            // MonthLbl
            // 
            this.MonthLbl.AutoSize = true;
            this.MonthLbl.Location = new System.Drawing.Point(55, 129);
            this.MonthLbl.Name = "MonthLbl";
            this.MonthLbl.Size = new System.Drawing.Size(40, 13);
            this.MonthLbl.TabIndex = 21;
            this.MonthLbl.Text = "Month:";
            // 
            // betterSplitButton1
            // 
            this.betterSplitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betterSplitButton1.Location = new System.Drawing.Point(86, 153);
            this.betterSplitButton1.Name = "betterSplitButton1";
            this.betterSplitButton1.Size = new System.Drawing.Size(130, 23);
            this.betterSplitButton1.TabIndex = 22;
            this.betterSplitButton1.Text = "Firts";
            this.betterSplitButton1.SplitButtonClick += new System.EventHandler(this.betterSplitButton1_SplitButtonClick);
            // 
            // BuyingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 251);
            this.Controls.Add(this.betterSplitButton1);
            this.Controls.Add(this.MonthLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.MonthTxt);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.CodeTxt);
            this.Controls.Add(this.NumberTxt);
            this.Controls.Add(this.CodeLbl);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyingWindow";
            this.Load += new System.EventHandler(this.BuyingWindow_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BuyingWindow_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuyingWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuyingWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuyingWindow_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label CodeLbl;
        private System.Windows.Forms.TextBox NumberTxt;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.TextBox YearTxt;
        private System.Windows.Forms.TextBox MonthTxt;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label MonthLbl;
        private ComponentOwl.BetterSplitButton.BetterSplitButton betterSplitButton1;
    }
}