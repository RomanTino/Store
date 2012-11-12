// -----------------------------------------------------------------------
// <copyright file="Order.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum OrderStatus
    {
        Pending, Danie, Accepted, Delivered
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Order
    {
        private Card cardData;
        private OrderStatus status;
        private List<Product> products;

        public Order()
        {
            this.cardData = new Card();
            this.status = OrderStatus.Pending;
            this.products = new List<Product>();
        }

        public Order(int productsCount)
        {
            this.cardData = new Card();
            this.status = OrderStatus.Pending;
            this.products = new List<Product>();
            for (int i = 0; i < productsCount; i++)
            {
                this.products[i] = new Product();
            }
        }

        public Order(Card inCard, List<Product> inProducts)
        {
            this.cardData = inCard;
            this.products = inProducts;
            this.status = OrderStatus.Pending;
        }

        public Card CardData
        {
            get
            {
                return this.cardData;
            }

            set
            {
                this.cardData = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }

            set
            {
                this.products = value;
            }
        }

        public OrderStatus Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.status = value;
            }
        }
    }
}