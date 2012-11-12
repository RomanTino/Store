// -----------------------------------------------------------------------
// <copyright file="Card.cs" company="Socket developers">
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
    public class Card
    {
        /// <summary>
        /// The field that contains number of card.
        /// </summary>
        private int number;

        /// <summary>
        /// The field that contains code of card.
        /// </summary>
        private int code;

        /// <summary>
        /// The field that contains month of payment.
        /// </summary>
        private string month;

        /// <summary>
        /// The field that contains year of payment.
        /// </summary>
        private int year;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// Default constructor.
        /// </summary>
        public Card()
        {
            this.number = 0;
            this.code = 0;
            this.month = DateTime.Now.Month.ToString();
            this.year = DateTime.Now.Year;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inNumber">Card number.</param>
        /// <param name="inCode">Card code.</param>
        /// <param name="inMonth">The month of payment.</param>
        /// <param name="inYear">The year of payment.</param>
        public Card(int inNumber, int inCode, string inMonth, int inYear)
        {
            this.number = inNumber;
            this.code = inCode;
            this.month = inMonth;
            this.year = inYear;
        }

        /// <summary>
        /// Gets or sets card number.
        /// </summary>
        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }

        /// <summary>
        /// Gets or sets card code.
        /// </summary>
        public int Code
        {
            get
            {
                return this.code;
            }

            set
            {
                this.code = value;
            }
        }

        /// <summary>
        /// Gets or sets month.
        /// </summary>
        public string Mounth
        {
            get
            {
                return this.month;
            }

            set
            {
                this.month = value;
            }
        }

        /// <summary>
        /// Gets or sets year.
        /// </summary>
        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }
        }
    }
}