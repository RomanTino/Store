using Socket.BLL.View;
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
            this.BuyBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EditCartGb = new System.Windows.Forms.GroupBox();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.CartLV = new Socket.BLL.View.MyListView();
            this.EditCartGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartLV)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyBtn
            // 
            this.BuyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyBtn.BackColor = System.Drawing.Color.LightGray;
            this.BuyBtn.Enabled = false;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Location = new System.Drawing.Point(50, 52);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(75, 23);
            this.BuyBtn.TabIndex = 3;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackColor = System.Drawing.Color.LightGray;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(50, 81);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackColor = System.Drawing.Color.LightGray;
            this.ClearBtn.Enabled = false;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(50, 110);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EditCartGb
            // 
            this.EditCartGb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCartGb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditCartGb.Controls.Add(this.TotalTxt);
            this.EditCartGb.Controls.Add(this.TotalLbl);
            this.EditCartGb.Controls.Add(this.DeleteBtn);
            this.EditCartGb.Controls.Add(this.ClearBtn);
            this.EditCartGb.Controls.Add(this.BuyBtn);
            this.EditCartGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCartGb.Location = new System.Drawing.Point(531, 3);
            this.EditCartGb.Name = "EditCartGb";
            this.EditCartGb.Size = new System.Drawing.Size(171, 138);
            this.EditCartGb.TabIndex = 6;
            this.EditCartGb.TabStop = false;
            this.EditCartGb.Text = "Edit cart";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(13, 26);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(31, 13);
            this.TotalLbl.TabIndex = 6;
            this.TotalLbl.Text = "Total";
            // 
            // TotalTxt
            // 
            this.TotalTxt.BackColor = System.Drawing.Color.White;
            this.TotalTxt.Enabled = false;
            this.TotalTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TotalTxt.Location = new System.Drawing.Point(50, 23);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(75, 20);
            this.TotalTxt.TabIndex = 7;
            this.TotalTxt.Text = "0$";
            // 
            // CartLV
            // 
            this.CartLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartLV.Location = new System.Drawing.Point(3, 3);
            this.CartLV.Name = "CartLV";
            this.CartLV.Size = new System.Drawing.Size(502, 458);
            this.CartLV.TabIndex = 2;
            this.CartLV.SelectedItemsChanged += new ComponentOwl.BetterListView.BetterListViewSelectedItemsChangedEventHandler(this.CartLV_SelectedItemsChanged);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EditCartGb);
            this.Controls.Add(this.CartLV);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(712, 478);
            this.EditCartGb.ResumeLayout(false);
            this.EditCartGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyListView CartLV;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.GroupBox EditCartGb;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label TotalLbl;

    }
}
