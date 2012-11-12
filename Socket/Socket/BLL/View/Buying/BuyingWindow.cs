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

    public partial class BuyingWindow : Form
    {
        private Controler control;

        private int mouseCordsX = 0;
        private int mouseCordsY = 0;
        bool isMouseMove;

        public BuyingWindow()
        {
            InitializeComponent();
            betterSplitButton1.AlwaysDropDown = true;
            betterSplitButton1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            Image image = new Bitmap(@"C:\Users\Роман\Desktop\Socket project\Socket\Socket\Resources\Logo.jpg");
            EventHandler onClickHandler = new EventHandler(onClick);
            betterSplitButton1.ContextMenuStrip.Items.Add("One", image, onClickHandler);
            betterSplitButton1.ContextMenuStrip.Items.Add("Two");
        }

        public void SetControl(Controler inControl)
        {
            control = inControl;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            control.CloseBuyingWindow();
        }

        private void LoginWindow_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void BuyingWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseMove == true)
            {
                this.DesktopLocation = new Point(this.DesktopLocation.X + (e.X - mouseCordsX), this.DesktopLocation.Y + (e.Y - mouseCordsY));
            }
        }

        private void BuyingWindow_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseMove = false;
        }

        private void BuyingWindow_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseCordsX = e.X;
            this.mouseCordsY = e.Y;
            this.isMouseMove = true;
        }

        private void BuyingWindow_MouseClick(object sender, MouseEventArgs e)
        {
            this.mouseCordsX = e.X;
            this.mouseCordsY = e.Y;
        }

        private void BuyingWindow_Load(object sender, EventArgs e)
        {
            YearTxt.Text = DateTime.Now.Year.ToString();
            MonthTxt.Text = DateTime.Now.Month.ToString();
            // TODO: This line of code loads data into the '_Socket_adp_mdb__0___ОстанняВерсіяDataSet1.Cards' table. You can move, or remove it, as needed.
            //this.cardsTableAdapter.Fill(this._Socket_adp_mdb__0___ОстанняВерсіяDataSet1.Cards);
        }

        private void betterSplitButton1_SplitButtonClick(object sender, EventArgs e)
        {
            
        }

        private void onClick(object sender, EventArgs e)
        {
            betterSplitButton1.Text = ((ToolStripItem)sender).Text;
        }
    }
}
