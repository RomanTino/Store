// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum PersonStatus
    {
        User, Staff, Banned
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Person
    {
        private string name;
        private string surname;
        private string nick;
        private string password;
        private string email;
        private string phoneNumber;
        private PersonStatus status;

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

        public String Name
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

        public String Surname
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