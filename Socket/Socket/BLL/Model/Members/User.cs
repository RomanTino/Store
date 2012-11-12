// -----------------------------------------------------------------------
// <copyright file="User.cs" company="Socket developers">
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
    /// Enumeration for users status.
    /// </summary>
    public enum UserStatus
    {
        /// <summary>
        /// User is logged.
        /// </summary>
        Logged,

        /// <summary>
        /// User is not logged.
        /// </summary>
        NotLogged
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The field that contains a user's person data.
        /// </summary>
        private Person personData;

        /// <summary>
        /// The field that contains a price in UAH.
        /// </summary>
        private int priceUAH;

        /// <summary>
        /// The field that contains a price in USD.
        /// </summary>
        private int priceUSD;

        /// <summary>
        /// The field that contains a user's status.
        /// </summary>
        private UserStatus status;

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// Default constructor.
        /// </summary>
        public User()
        {
            this.personData = new Person();
            this.priceUAH = 0;
            this.priceUSD = 0;
            this.status = UserStatus.NotLogged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inPersonData">User's person data.</param>
        /// <param name="inPriceUAH">Price in UAH.</param>
        /// <param name="inPriceUSD">Price in USD.</param>
        /// <param name="inStatus">User's status.</param>
        public User(Person inPersonData, int inPriceUAH, int inPriceUSD, UserStatus inStatus)
        {
            this.personData = inPersonData;
            this.priceUAH = inPriceUAH;
            this.priceUSD = inPriceUSD;
            this.status = inStatus;
        }

        /// <summary>
        /// Gets or sets user's person data.
        /// </summary>
        public Person PersonData
        {
            get
            {
                return this.personData;
            }

            set
            {
                this.personData = value;
            }
        }

        /// <summary>
        /// Gets or sets price in UAH.
        /// </summary>
        public int PriceUAH
        {
            get
            {
                return this.priceUAH;
            }

            set
            {
                this.priceUAH = value;
            }
        }

        /// <summary>
        /// Gets or sets price in USD.
        /// </summary>
        public int PriceUSD
        {
            get
            {
                return this.priceUSD;
            }

            set
            {
                this.priceUSD = value;
            }
        }

        /// <summary>
        /// Gets or sets user's status.
        /// </summary>
        public UserStatus Status
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