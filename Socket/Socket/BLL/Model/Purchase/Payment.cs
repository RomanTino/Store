// -----------------------------------------------------------------------
// <copyright file="Payment.cs" company="Socket developers">
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
        /// <summary>
        /// The field that contains a customers that make payments.
        /// </summary>
        private User customer;

        /// <summary>
        /// The field that contains an order's payments.
        /// </summary>
        private List<Order> orders;

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// Default constructor.
        /// </summary>
        public Payment()
        {
            this.customer = new User();
            this.orders = new List<Order>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="ordersCount">Count of orders.</param>
        public Payment(int ordersCount)
        {
            this.customer = new User();
            this.orders = new List<Order>();
            for (int i = 0; i < ordersCount; i++)
            {
                this.orders[i] = new Order();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inCustomer">Customers that make payments.</param>
        /// <param name="inOrders">Order's payments.</param>
        public Payment(User inCustomer, List<Order> inOrders)
        {
            this.customer = inCustomer;
            this.orders = inOrders;
        }

        /// <summary>
        /// Gets or sets customers that make payments.
        /// </summary>
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

        /// <summary>
        /// Gets or sets order's payments.
        /// </summary>
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