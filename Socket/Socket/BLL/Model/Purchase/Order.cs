// -----------------------------------------------------------------------
// <copyright file="Order.cs" company="Socket developers">
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
    /// Enumeration for orders status.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Order is pending.
        /// </summary>
        Pending, 
        
        /// <summary>
        /// Oder was denied.
        /// </summary>
        Danie, 
        
        /// <summary>
        /// Oder accepted.
        /// </summary>
        Accepted,
        
        /// <summary>
        /// Order was delivered.
        /// </summary>
        Delivered
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The field that contains an order's card data.
        /// </summary>
        private Card cardData;

        /// <summary>
        /// The field that contains an order's status.
        /// </summary>
        private OrderStatus status;

        /// <summary>
        /// The field that contains an order's list of products.
        /// </summary>
        private List<Product> products;

        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Default constructor.
        /// </summary>
        public Order()
        {
            this.cardData = new Card();
            this.status = OrderStatus.Pending;
            this.products = new List<Product>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="productsCount">Order's count of products.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inCard">Order's card.</param>
        /// <param name="inProducts">Order's products.</param>
        public Order(Card inCard, List<Product> inProducts)
        {
            this.cardData = inCard;
            this.products = inProducts;
            this.status = OrderStatus.Pending;
        }

        /// <summary>
        /// Gets or sets order's card data.
        /// </summary>
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

        /// <summary>
        /// Gets or sets order's list of products.
        /// </summary>
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

        /// <summary>
        /// Gets or sets order's status.
        /// </summary>
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