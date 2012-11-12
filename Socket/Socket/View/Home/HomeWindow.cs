namespace Socket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Socket.Control;
    using Socket.View.Home;

    public partial class HomeWindow : Form
    {
        private Controler control;

        private StorePage storePage;
        private CartPage cartPage;
        private UserPage userPage;
        private AdminPage adminPage;

        public HomeWindow()
        {
            this.InitializeComponent();

            this.SetStorePage();
            this.tabPage1.Controls.Add(this.storePage);
            this.SetCartPage();
            this.tabPage2.Controls.Add(this.cartPage);
            this.SetUserPage();
            this.tabPage3.Controls.Add(this.userPage);
            this.SetAdminPage();
            this.tabPage4.Controls.Add(this.adminPage);
        }

        public void SetControler(Controler inControl)
        {
            this.control = inControl;
        }

        private void SetStorePage()
        {
            this.storePage = new StorePage();
            this.storePage.Height = tabPage1.Height;
            this.storePage.Width = tabPage1.Width;
        }

        private void SetCartPage()
        {
            this.cartPage = new CartPage();
            this.cartPage.Height = tabPage2.Height;
            this.cartPage.Width = tabPage2.Height;
        }

        private void SetUserPage()
        {
            this.userPage = new UserPage();
            this.userPage.Width = tabPage3.Width;
            this.userPage.Height = tabPage3.Height;
        }

        private void SetAdminPage()
        {
            this.adminPage = new AdminPage();
            this.adminPage.Width = this.tabPage4.Width;
            this.adminPage.Height = this.tabPage4.Height;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.control.RunLoginWindow();
        }

        private void TabPage1Btn_Click(object sender, EventArgs e)
        {
            this.hometabCtrl.SelectedTab = this.tabPage1;
            this.tabPage1Btn.Select();
        }

        private void TabPage2Btn_Click(object sender, EventArgs e)
        {
            this.hometabCtrl.SelectedTab = this.tabPage2;
            this.tabPage2Btn.Select();
        }

        private void TabPage3Btn_Click(object sender, EventArgs e)
        {
            this.hometabCtrl.SelectedTab = this.tabPage3;
            this.tabPage3Btn.Select();
        }

        private void TabPage4Btn_Click(object sender, EventArgs e)
        {
            this.hometabCtrl.SelectedTab = this.tabPage4;
            this.tabPage4Btn.Select();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.control.RunRegistrationWindow();
        }
    }
}
