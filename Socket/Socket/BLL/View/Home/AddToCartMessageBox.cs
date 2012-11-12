using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Socket.View;

namespace Socket.BLL.View.Home
{
    public partial class AddToCartMessageBox : Form
    {
        private int mouseCordsX = 0;
        private int mouseCordsY = 0;
        bool isMouseMove;

        public AddToCartMessageBox()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void AddToCartMessageBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.mouseCordsX = e.X;
            this.mouseCordsY = e.Y;
        }

        private void AddToCartMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMove == true)
            {
                this.DesktopLocation = new Point(this.DesktopLocation.X + (e.X - mouseCordsX), this.DesktopLocation.Y + (e.Y - mouseCordsY));
            }
        }

        private void AddToCartMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseCordsX = e.X;
            this.mouseCordsY = e.Y;
            this.isMouseMove = true;
        }

        private void AddToCartMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseMove = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
