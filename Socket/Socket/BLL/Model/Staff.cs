// -----------------------------------------------------------------------
// <copyright file="Staff.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum StaffStatus
    {
        Admin, Manager, Financier, NotSetted
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Staff
    {
        private Person personData;
        private StaffStatus status;

        public Staff()
        {
            this.personData = new Person();
            this.status = StaffStatus.NotSetted;
        }

        public Staff(Person inPersonData, StaffStatus inStatus)
        {
            this.personData = inPersonData;
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

        public StaffStatus Status
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
