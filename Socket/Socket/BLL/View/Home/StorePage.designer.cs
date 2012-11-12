using System.Windows.Forms;
using Socket.BLL.View;
namespace Socket.View.Home
{
    partial class StorePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorePage));
            this.ComputerGB = new System.Windows.Forms.GroupBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ScreenLbl = new System.Windows.Forms.Label();
            this.ScreenTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.VCTxt = new System.Windows.Forms.TextBox();
            this.VCLbl = new System.Windows.Forms.Label();
            this.HDDLbl = new System.Windows.Forms.Label();
            this.RAMLbl = new System.Windows.Forms.Label();
            this.CPULbl = new System.Windows.Forms.Label();
            this.PCNameLbl = new System.Windows.Forms.Label();
            this.HDDTxt = new System.Windows.Forms.TextBox();
            this.RAMTxt = new System.Windows.Forms.TextBox();
            this.CPUTxt = new System.Windows.Forms.TextBox();
            this.PCNameTxt = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StorelistView = new Socket.BLL.View.MyListView();
            this.ComputerGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorelistView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerGB
            // 
            this.ComputerGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComputerGB.Controls.Add(this.AddBtn);
            this.ComputerGB.Controls.Add(this.ScreenLbl);
            this.ComputerGB.Controls.Add(this.ScreenTxt);
            this.ComputerGB.Controls.Add(this.PriceTxt);
            this.ComputerGB.Controls.Add(this.PriceLbl);
            this.ComputerGB.Controls.Add(this.VCTxt);
            this.ComputerGB.Controls.Add(this.VCLbl);
            this.ComputerGB.Controls.Add(this.HDDLbl);
            this.ComputerGB.Controls.Add(this.RAMLbl);
            this.ComputerGB.Controls.Add(this.CPULbl);
            this.ComputerGB.Controls.Add(this.PCNameLbl);
            this.ComputerGB.Controls.Add(this.HDDTxt);
            this.ComputerGB.Controls.Add(this.RAMTxt);
            this.ComputerGB.Controls.Add(this.CPUTxt);
            this.ComputerGB.Controls.Add(this.PCNameTxt);
            this.ComputerGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComputerGB.Location = new System.Drawing.Point(569, 3);
            this.ComputerGB.Name = "ComputerGB";
            this.ComputerGB.Size = new System.Drawing.Size(281, 218);
            this.ComputerGB.TabIndex = 3;
            this.ComputerGB.TabStop = false;
            this.ComputerGB.Text = "Computer info";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightGray;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(200, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ScreenLbl
            // 
            this.ScreenLbl.AutoSize = true;
            this.ScreenLbl.Location = new System.Drawing.Point(43, 166);
            this.ScreenLbl.Name = "ScreenLbl";
            this.ScreenLbl.Size = new System.Drawing.Size(41, 13);
            this.ScreenLbl.TabIndex = 13;
            this.ScreenLbl.Text = "Screen";
            // 
            // ScreenTxt
            // 
            this.ScreenTxt.BackColor = System.Drawing.Color.White;
            this.ScreenTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScreenTxt.Enabled = false;
            this.ScreenTxt.Location = new System.Drawing.Point(90, 163);
            this.ScreenTxt.Name = "ScreenTxt";
            this.ScreenTxt.Size = new System.Drawing.Size(145, 20);
            this.ScreenTxt.TabIndex = 12;
            // 
            // PriceTxt
            // 
            this.PriceTxt.BackColor = System.Drawing.Color.White;
            this.PriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTxt.Enabled = false;
            this.PriceTxt.Location = new System.Drawing.Point(90, 189);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(145, 20);
            this.PriceTxt.TabIndex = 11;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(53, 191);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(31, 13);
            this.PriceLbl.TabIndex = 10;
            this.PriceLbl.Text = "Price";
            // 
            // VCTxt
            // 
            this.VCTxt.BackColor = System.Drawing.Color.White;
            this.VCTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VCTxt.Enabled = false;
            this.VCTxt.Location = new System.Drawing.Point(90, 136);
            this.VCTxt.Name = "VCTxt";
            this.VCTxt.Size = new System.Drawing.Size(145, 20);
            this.VCTxt.TabIndex = 9;
            // 
            // VCLbl
            // 
            this.VCLbl.AutoSize = true;
            this.VCLbl.Location = new System.Drawing.Point(26, 138);
            this.VCLbl.Name = "VCLbl";
            this.VCLbl.Size = new System.Drawing.Size(58, 13);
            this.VCLbl.TabIndex = 8;
            this.VCLbl.Text = "Video card";
            // 
            // HDDLbl
            // 
            this.HDDLbl.AutoSize = true;
            this.HDDLbl.Location = new System.Drawing.Point(53, 111);
            this.HDDLbl.Name = "HDDLbl";
            this.HDDLbl.Size = new System.Drawing.Size(31, 13);
            this.HDDLbl.TabIndex = 7;
            this.HDDLbl.Text = "HDD";
            // 
            // RAMLbl
            // 
            this.RAMLbl.AutoSize = true;
            this.RAMLbl.Location = new System.Drawing.Point(53, 84);
            this.RAMLbl.Name = "RAMLbl";
            this.RAMLbl.Size = new System.Drawing.Size(31, 13);
            this.RAMLbl.TabIndex = 6;
            this.RAMLbl.Text = "RAM";
            // 
            // CPULbl
            // 
            this.CPULbl.AutoSize = true;
            this.CPULbl.Location = new System.Drawing.Point(53, 57);
            this.CPULbl.Name = "CPULbl";
            this.CPULbl.Size = new System.Drawing.Size(29, 13);
            this.CPULbl.TabIndex = 5;
            this.CPULbl.Text = "CPU";
            // 
            // PCNameLbl
            // 
            this.PCNameLbl.AutoSize = true;
            this.PCNameLbl.Location = new System.Drawing.Point(53, 30);
            this.PCNameLbl.Name = "PCNameLbl";
            this.PCNameLbl.Size = new System.Drawing.Size(35, 13);
            this.PCNameLbl.TabIndex = 4;
            this.PCNameLbl.Text = "Name";
            // 
            // HDDTxt
            // 
            this.HDDTxt.BackColor = System.Drawing.Color.White;
            this.HDDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDTxt.Enabled = false;
            this.HDDTxt.Location = new System.Drawing.Point(90, 109);
            this.HDDTxt.Name = "HDDTxt";
            this.HDDTxt.Size = new System.Drawing.Size(145, 20);
            this.HDDTxt.TabIndex = 3;
            // 
            // RAMTxt
            // 
            this.RAMTxt.BackColor = System.Drawing.Color.White;
            this.RAMTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RAMTxt.Enabled = false;
            this.RAMTxt.Location = new System.Drawing.Point(90, 82);
            this.RAMTxt.Name = "RAMTxt";
            this.RAMTxt.Size = new System.Drawing.Size(145, 20);
            this.RAMTxt.TabIndex = 2;
            // 
            // CPUTxt
            // 
            this.CPUTxt.BackColor = System.Drawing.Color.White;
            this.CPUTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTxt.Enabled = false;
            this.CPUTxt.Location = new System.Drawing.Point(90, 55);
            this.CPUTxt.Name = "CPUTxt";
            this.CPUTxt.Size = new System.Drawing.Size(145, 20);
            this.CPUTxt.TabIndex = 1;
            // 
            // PCNameTxt
            // 
            this.PCNameTxt.BackColor = System.Drawing.Color.White;
            this.PCNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCNameTxt.Enabled = false;
            this.PCNameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PCNameTxt.Location = new System.Drawing.Point(90, 28);
            this.PCNameTxt.Name = "PCNameTxt";
            this.PCNameTxt.Size = new System.Drawing.Size(145, 20);
            this.PCNameTxt.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "apple_macbook_pro_mc724rs_a_2992454.jpg");
            this.imageList1.Images.SetKeyName(1, "copy_acer_travelmate_5744z_p622g32mnkk_nx_v5neu_001_503cccda92aa2_7018124.jpg");
            this.imageList1.Images.SetKeyName(2, "copy_hp_probook_4540s_c5d55ea_505c49e149d9f_7150695.jpg");
            // 
            // StorelistView
            // 
            this.StorelistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StorelistView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StorelistView.HideSelectionMode = ComponentOwl.BetterListView.BetterListViewHideSelectionMode.Disable;
            this.StorelistView.Location = new System.Drawing.Point(3, 3);
            this.StorelistView.MultiSelect = false;
            this.StorelistView.Name = "StorelistView";
            this.StorelistView.Size = new System.Drawing.Size(560, 544);
            this.StorelistView.TabIndex = 4;
            this.StorelistView.SelectedIndexChanged += new System.EventHandler(this.StorelistView_SelectedIndexChanged);
            // 
            // StorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StorelistView);
            this.Controls.Add(this.ComputerGB);
            this.Name = "StorePage";
            this.Size = new System.Drawing.Size(864, 563);
            this.ComputerGB.ResumeLayout(false);
            this.ComputerGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorelistView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComputerGB;
        private System.Windows.Forms.TextBox VCTxt;
        private System.Windows.Forms.Label VCLbl;
        private System.Windows.Forms.Label HDDLbl;
        private System.Windows.Forms.Label RAMLbl;
        private System.Windows.Forms.Label CPULbl;
        private System.Windows.Forms.Label PCNameLbl;
        private System.Windows.Forms.TextBox HDDTxt;
        private System.Windows.Forms.TextBox RAMTxt;
        private System.Windows.Forms.TextBox CPUTxt;
        private System.Windows.Forms.TextBox PCNameTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label PriceLbl;
        private MyListView StorelistView;
        private System.Windows.Forms.ImageList imageList1;
        private Label ScreenLbl;
        private TextBox ScreenTxt;
        private Button AddBtn;
    }
}
