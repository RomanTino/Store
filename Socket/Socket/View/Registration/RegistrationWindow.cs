using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Socket.Control;

namespace Socket
{
    public partial class RegistrationWindow : Form
    {
        private Controler control;

        private int mouseCordsX = 0;
        private int mouseCordsY = 0;
        bool isMouseMove;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        public void SetControler(Controler inControl)
        {
            this.control = inControl;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void RegistrationWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMove == true)
            {
                this.DesktopLocation = new Point(this.DesktopLocation.X + (e.X - mouseCordsX), this.DesktopLocation.Y + (e.Y - mouseCordsY));
            }
        }

        private void RegistrationWindow_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseMove = false;
        }

        private void RegistrationWindow_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseCordsX = e.X;
            this.mouseCordsY = e.Y;
            this.isMouseMove = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            control.CloseReRegistrationWindow();
        }
    }
}
