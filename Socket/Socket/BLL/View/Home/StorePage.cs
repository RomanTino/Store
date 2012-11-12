using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Socket.Control;
using Socket.Model;
using Socket.BLL.View;
using ComponentOwl.BetterListView;
using Socket.BLL.View.Home;

namespace Socket.View.Home
{
    public partial class StorePage : UserControl
    {
        Controler control;

        public StorePage()
        {
            InitializeComponent();
        }

        public void SetControl(Controler inControl)
        {
            this.control = inControl;
        }

        public void SetProdusts(List<Product> products)
        {
            BetterListViewItem item;
            StorelistView.Columns.Add("Name", 400);
            StorelistView.Columns.Add("Price", 100);
            int count = 0;
            foreach (Product product in products)
            {
                item = new BetterListViewItem(product.Name);
                item.ForeColor = Color.Black;
                item.SubItems.Add(product.PriceUSD.ToString());
                item.ImageIndex = count;
                item.Image = imageList1.Images[count];
                StorelistView.Items.Add(item);
                count++; 
            }   
        }

        private void StorelistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyListView list = (MyListView)sender;
            if (list.SelectedIndices.Count > 0)
            {
                Product toView = control.LoadProduct(list.SelectedIndices[0]);
                PCNameTxt.Text = toView.Name;
                CPUTxt.Text = toView.CPU;
                RAMTxt.Text = toView.RAM;
                HDDTxt.Text = toView.HDD;
                VCTxt.Text = toView.VideoCard;
                ScreenTxt.Text = toView.Screen;
                PriceTxt.Text = toView.PriceUSD.ToString() + '$';
                if (this.ComputerGB.Height < 256)
                {
                    this.ComputerGB.Height += 38;
                }
            }
            else
            {
                if (this.ComputerGB.Height > 218)
                {
                    this.ComputerGB.Height -= 38;
                    PCNameTxt.Text = string.Empty;
                    CPUTxt.Text = string.Empty;
                    RAMTxt.Text = string.Empty;
                    HDDTxt.Text = string.Empty;
                    VCTxt.Text = string.Empty;
                    ScreenTxt.Text = string.Empty;
                    PriceTxt.Text = string.Empty;
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            control.AddToCart(StorelistView.SelectedIndices[0]);
            AddToCartMessageBox messagwBox = new AddToCartMessageBox();
            messagwBox.ShowDialog();
        }
    }
}
