// -----------------------------------------------------------------------
// <copyright file="Controler.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Controler
    {
        private HomeWindow homeWindow;
        private LoginWindow loginWindow;
        private RegistrationWindow registrationWindow;
        private BuyingWindow buyingWindow;

        public Controler()
        {
            this.homeWindow = new HomeWindow();
            this.homeWindow.SetControler(this);
        }

        public HomeWindow GetHomeWindow()
        {
            return homeWindow;
        }

        public void RunLoginWindow()
        {
            this.loginWindow = new LoginWindow();
            this.loginWindow.SetControler(this);
            this.loginWindow.ShowDialog();
        }

        public void CloseLoginWondow()
        {
            this.loginWindow.Close();
        }

        public void RunRegistrationWindow()
        {
            this.registrationWindow = new RegistrationWindow();
            this.registrationWindow.SetControler(this);
            this.registrationWindow.ShowDialog();
        }

        public void CloseReRegistrationWindow()
        {
            this.registrationWindow.Close();
        }

        public void RunBuyingWindow()
        {
            this.buyingWindow = new BuyingWindow();
            this.buyingWindow.ShowDialog();
        }

        public void CloseBuyingWindow()
        {
            this.buyingWindow.Close();
        }
    }
}
