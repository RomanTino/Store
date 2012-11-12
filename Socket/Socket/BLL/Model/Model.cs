// -----------------------------------------------------------------------
// <copyright file="Model.cs" company="Socket developers">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Socket.CRUD;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// The field that contains persons.
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// The field that contains staffs.
        /// </summary>
        private List<Staff> staffs;

        /// <summary>
        /// The field that contains users.
        /// </summary>
        private List<User> users;

        /// <summary>
        /// The field that contains products.
        /// </summary>
        private List<Product> products;

        /// <summary>
        /// The field that contains cards.
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// The field that contains orders.
        /// </summary>
        private List<Order> orders;

        /// <summary>
        /// The field that contains payments.
        /// </summary>
        private List<Payment> payments;

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// Default constructor.
        /// </summary>
        public Model()
        {
            this.ReadTable();
        }

        /// <summary>
        /// Gets or sets persons.
        /// </summary>
        public List<Person> Persons
        {
            get
            {
                return this.persons;
            }

            set
            {
                this.persons = value;
            }
        }

        /// <summary>
        /// Gets or sets staffs.
        /// </summary>
        public List<Staff> Staffs
        {
            get
            {
                return this.staffs;
            }

            set
            {
                this.staffs = value;
            }
        }

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        public List<User> Users
        {
            get
            {
                return this.users;
            }

            set
            {
                this.users = value;
            }
        }

        /// <summary>
        /// Gets or sets products.
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
        /// Gets or sets cards.
        /// </summary>
        public List<Card> Cards
        {
            get
            {
                return this.cards;
            }

            set
            {
                this.cards = value;
            }
        }

        /// <summary>
        /// Gets or sets orders.
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

        /// <summary>
        /// Gets or sets payments.
        /// </summary>
        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                this.payments = value;
            }
        }

        /// <summary>
        /// Reads the table of products.
        /// </summary>
        private void ReadTable()
        {
            this.persons = new List<Person>();
            this.staffs = new List<Staff>();
            this.users = new List<User>();
            this.products = new List<Product>();
            this.products.Add(new Product("Apple MacBook Pro", 1600, "Intel Core i7 (2.7 ГГц)", "4 Gb", "500 Gb", "Intel HD Graphics 3000", "13.3'' (1280x800) LED"));
            this.products.Add(new Product("Acer TravelMate 5744-384G50Mnkk", 439, "Intel Core i3-380M (2.53 ГГц)", "4 Gb", "500 Gb", "Intel GMA HD", "15.6'' 1366x768 LED"));
            this.products.Add(new Product("HP ProBook 4540s", 773, "Intel Core i5-3210M (2.5 ГГц)", "6 Gb", "750 Gb", "AMD Radeon HD 7650", "15.6'' (1366x768) HD LED"));
            this.cards = new List<Card>();
            this.orders = new List<Order>();
            this.payments = new List<Payment>();
            /*PersonCRUD crudPerson = new PersonCRUD();
            this.persons = crudPerson.TablRead();
            StaffCRUD crudStaff = new StaffCRUD();
            this.staffs = crudStaff.TablRead();
            UserCRUD crudUser = new UserCRUD();
            this.users = crudUser.TablRead();
            ProductCRUD crudProduct = new ProductCRUD();

            ////products = crudProduct.TablRead();
            CardCRUD crudCard = new CardCRUD();
            this.cards = crudCard.TablRead();
            OrderCRUD crudOrder = new OrderCRUD();
            this.orders = crudOrder.TablRead();
            PaymentCRUD crudPayment = new PaymentCRUD();
            this.payments = crudPayment.TablRead();*/
        }
    }
}
