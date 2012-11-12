// -----------------------------------------------------------------------
// <copyright file="Staff.cs" company="Socket developers">
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
    /// Enumeration for staffs status.
    /// </summary>
    public enum StaffStatus
    {
        /// <summary>
        /// Staff member is an admin.
        /// </summary>
        Admin,

        /// <summary>
        /// Staff member is an manager.
        /// </summary>
        Manager,

        /// <summary>
        /// Staff member is an financier.
        /// </summary>
        Financier,

        /// <summary>
        /// Status of personnel is not set.
        /// </summary>
        NotSetted
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// The field that contains a staff's person data.
        /// </summary>
        private Person personData;

        /// <summary>
        /// The field that contains a staff's status.
        /// </summary>
        private StaffStatus status;

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff" /> class.
        /// Default constructor.
        /// </summary>
        public Staff()
        {
            this.personData = new Person();
            this.status = StaffStatus.NotSetted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inPersonData">Staff's person data.</param>
        /// <param name="inStatus">Staff's status.</param>
        public Staff(Person inPersonData, StaffStatus inStatus)
        {
            this.personData = inPersonData;
            this.status = inStatus;
        }

        /// <summary>
        /// Gets or sets staff's person data.
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
        /// Gets or sets staff's status.
        /// </summary>
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