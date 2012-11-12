// -----------------------------------------------------------------------
// <copyright file="User.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum UserStatus
    {
        Logged, NotLogged
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class User
    {
        private Person personData;
        private int priceUAH;
        private int priceUSD;
        private UserStatus status;

        public User()
        {
            this.personData = new Person();
            this.priceUAH = 0;
            this.priceUSD = 0;
            this.status = UserStatus.NotLogged;
        }

        public User(Person inPersonData, int inPriceUAH, int inPriceUSD, UserStatus inStatus)
        {
            this.personData = inPersonData;
            this.priceUAH = inPriceUAH;
            this.priceUSD = inPriceUSD;
            this.status = inStatus;
        }

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