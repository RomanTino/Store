using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Socket.Control;
using Socket.Model;
using ComponentOwl.BetterListView;

namespace Socket.View.Home
{
    public partial class CartPage : UserControl
    {
        private Controler control;

        public CartPage()
        {
            this.InitializeComponent();
            this.setListView();
            if (this.CartLV.Items.Count > 0)
            {
                this.BuyBtn.Enabled = true;
            }
        }

        public void SetControl(Controler inControl)
        {
            this.control = inControl;
        }

        private void setListView()
        {
            this.CartLV.Columns.Add("Name", 200);
            this.CartLV.Columns.Add("CPU", 200);
            this.CartLV.Columns.Add("RAM", 100);
            this.CartLV.Columns.Add("HDD", 100);
            this.CartLV.Columns.Add("Video card", 200);
            this.CartLV.Columns.Add("Screen", 200);
            this.CartLV.Columns.Add("Price", 100);
        }

        public void AddProduct(Product product)
        {
            BetterListViewItem item = new BetterListViewItem(product.Name);
            item.SubItems.Add(product.CPU);
            item.SubItems.Add(product.RAM);
            item.SubItems.Add(product.HDD);
            item.SubItems.Add(product.VideoCard);
            item.SubItems.Add(product.Screen);
            item.SubItems.Add(product.PriceUSD);
            CartLV.Items.Add(item);

            this.changeEnabled();
            this.changeTotal();
        }

        private void changeEnabled()
        {
            if (CartLV.Items.Count > 0)
            {
                this.BuyBtn.Enabled = true;
                this.ClearBtn.Enabled = true;
            }
            else
            {
                this.BuyBtn.Enabled = false;
                this.ClearBtn.Enabled = false;
            }
        }

        private void changeTotal()
        {
            int total = 0;
            foreach (BetterListViewItem item in CartLV.Items)
            {
                total += int.Parse(item.SubItems[6].Text);
            }
            TotalTxt.Text = total.ToString() + '$';
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            this.control.RunBuyingWindow();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.CartLV.Items.Clear();
            this.changeEnabled();
            this.changeTotal();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (BetterListViewItem item in this.CartLV.SelectedItems)
            {
                this.CartLV.Items.Remove(item);
            }
            this.changeEnabled();
            this.changeTotal();
        }

        private void CartLV_SelectedItemsChanged(object sender, BetterListViewSelectedItemsChangedEventArgs eventArgs)
        {
            if (CartLV.SelectedItems.Count > 0)
            {
                this.DeleteBtn.Enabled = true;
            }
            else
            {
                this.DeleteBtn.Enabled = false;
            }
        }
    }
}
