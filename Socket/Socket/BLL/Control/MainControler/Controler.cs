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
    using Socket.Model;
    using Socket.View.Home;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Controler
    {
        private HomeWindow homeWindow;
        private LoginWindow loginWindow;
        private RegistrationWindow registrationWindow;
        private BuyingWindow buyingWindow;
        private Model model;

        private StorePage storePage;
        private CartPage cartPage;
        private UserPage userPage;
        private AdminPage adminPage;

        public Controler()
        {
            this.storePage = new StorePage();
            this.cartPage = new CartPage();
            this.userPage = new UserPage();
            this.adminPage = new AdminPage();

            this.model = new Model();

            
            this.homeWindow = new HomeWindow(storePage, cartPage, userPage, adminPage);
            this.homeWindow.SetControler(this);
            this.LoadProducts();
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
            this.buyingWindow.SetControl(this);
            this.buyingWindow.ShowDialog();
        }

        public void CloseBuyingWindow()
        {
            this.buyingWindow.Close();
        }

        public void LoadProducts()
        {
            storePage.SetProdusts(model.Products);
        }

        public Product LoadProduct(int index)
        {
            return model.Products[index];
        }

        public void AddToCart(int index)
        {
            cartPage.AddProduct(model.Products[index]);
        }
    }
}
