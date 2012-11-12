// -----------------------------------------------------------------------
// <copyright file="Payment.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Payment
    {
        private User customer;
        private List<Order> orders;

        public Payment()
        {
            this.customer = new User();
            this.orders = new List<Order>();
        }

        public Payment(int ordersCount)
        {
            this.customer = new User();
            this.orders = new List<Order>();
            for (int i = 0; i < ordersCount; i++)
            {
                this.orders[i] = new Order();
            }
        }

        public Payment(User inCustomer, List<Order> inOrders)
        {
            this.customer = inCustomer;
            this.orders = inOrders;
        }

        public User Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return this.orders;
            }

            set
            {
                this.orders = value;
            }
        }
    }
}