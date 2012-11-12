// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="Socket developers">
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
    /// Enumeration for persons status.
    /// </summary>
    public enum PersonStatus
    {
        /// <summary>
        /// Person is a user member.
        /// </summary>
        User,

        /// <summary>
        /// Person is a staff member.
        /// </summary>
        Staff,

        /// <summary>
        ///  Person is banned.
        /// </summary>
        Banned
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The field that contains a person's name.
        /// </summary>
        private string name;

        /// <summary>
        /// The field that contains a person's surname.
        /// </summary>
        private string surname;

        /// <summary>
        /// The field that contains a person's nickname.
        /// </summary>
        private string nick;

        /// <summary>
        /// The field that contains a person's password.
        /// </summary>
        private string password;

        /// <summary>
        /// The field that contains a person's email.
        /// </summary>
        private string email;

        /// <summary>
        /// The field that contains a person's phone number.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// The field that contains a person's status.
        /// </summary>
        private PersonStatus status;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// Default constructor.
        /// </summary>
        public Person()
        {
            this.name = "N/A";
            this.surname = "N/A";
            this.nick = "N/A";
            this.password = "N/A";
            this.email = "N/A";
            this.phoneNumber = "N/A";
            this.status = PersonStatus.User;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inName">Person's name.</param>
        /// <param name="inSurname">Person's surname.</param>
        /// <param name="inNick">Person's nickname.</param>
        /// <param name="inPassword">Person's password.</param>
        /// <param name="inEmail">Person's email.</param>
        /// <param name="inPhoneNumber">Person's phone number.</param>
        /// <param name="inStatus">Person's status.</param>
        public Person(string inName, string inSurname, string inNick, string inPassword, string inEmail, string inPhoneNumber, PersonStatus inStatus)
        {
            this.name = inName;
            this.surname = inSurname;
            this.nick = inNick;
            this.password = inPassword;
            this.email = inEmail;
            this.phoneNumber = inPhoneNumber;
            this.status = inStatus;
        }

        /// <summary>
        /// Gets or sets person's name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                value = this.name;
            }
        }

        /// <summary>
        /// Gets or sets person's surname.
        /// </summary>
        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
            }
        }

        /// <summary>
        /// Gets or sets person's nickname.
        /// </summary>
        public string Nick
        {
            get
            {
                return this.nick;
            }

            set
            {
                this.nick = value;
            }
        }

        /// <summary>
        /// Gets or sets person's password.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets person's email.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        /// <summary>
        /// Gets or sets person's phone number.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets person's status.
        /// </summary>
        public PersonStatus Status
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