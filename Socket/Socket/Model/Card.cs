// -----------------------------------------------------------------------
// <copyright file="Card.cs" company="">
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
        private int number;
        private int code;
        private string mounth;
        private int year;

        public Card()
        {
            this.number = 0;
            this.code = 0;
            this.mounth = DateTime.Now.Month.ToString();
            this.year = DateTime.Now.Year;
        }

        public Card(int inNumber, int inCode, string inMounth, int inYear)
        {
            this.number = inNumber;
            this.code = inCode;
            this.mounth = inMounth;
            this.year = inYear;
        }

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

        public string Mounth
        {
            get
            {
                return this.mounth;
            }

            set
            {
                this.mounth = value;
            }
        }

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
