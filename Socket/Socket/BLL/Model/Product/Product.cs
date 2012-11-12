// -----------------------------------------------------------------------
// <copyright file="Product.cs" company="Socket developers">
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
    public class Product
    {
        /// <summary>
        /// The field that contains a product's name.
        /// </summary>
        private string name;

        /// <summary>
        /// The field that contains a product's price in USD.
        /// </summary>
        private int priceUSD;

        /// <summary>
        /// The field that contains a product's CPU.
        /// </summary>
        private string cPU;

        /// <summary>
        /// The field that contains a product's RAM.
        /// </summary>
        private string rAM;

        /// <summary>
        /// The field that contains a product's HDD.
        /// </summary>
        private string hDD;

        /// <summary>
        /// The field that contains a product's graphics card.
        /// </summary>
        private string videoCard;

        /// <summary>
        /// The field that contains a product's screen resolution.
        /// </summary>
        private string screen;

        /// <summary>
        /// The field that contains a product's image address.
        /// </summary>
        private string imgAdr;

        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// Default constructor.
        /// </summary>
        public Product()
        {
            this.name = "N/A";
            this.priceUSD = 0;
            this.cPU = "N/A";
            this.rAM = "N/A";
            this.hDD = "N/A";
            this.videoCard = "N/A";
            this.screen = "N/A";
            this.imgAdr = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inName">Product's name.</param>
        /// <param name="inPriceUsd">Product's price in USD.</param>
        /// <param name="inCPU">Product's CPU.</param>
        /// <param name="inRAM">Product's RAM.</param>
        /// <param name="inHDD">Product's HDD.</param>
        /// <param name="inVideoCard">Product's graphics card.</param>
        /// <param name="inScreen">Product's screen resolution.</param>
        public Product(
            string inName,
            int inPriceUsd,
            string inCPU,
            string inRAM,
            string inHDD,
            string inVideoCard,
            string inScreen)
        {
            this.name = inName;
            this.priceUSD = inPriceUsd;
            this.cPU = inCPU;
            this.rAM = inRAM;
            this.hDD = inHDD;
            this.videoCard = inVideoCard;
            this.screen = inScreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// Constructor with arguments.
        /// </summary>
        /// <param name="inName">Product's name.</param>
        /// <param name="inPriceUsd">Product's price in USD.</param>
        /// <param name="inCPU">Product's CPU.</param>
        /// <param name="inRAM">Product's RAM.</param>
        /// <param name="inHDD">Product's HDD.</param>
        /// <param name="inVideoCard">Product's graphics card.</param>
        /// <param name="inScreen">Product's screen resolution.</param>
        /// <param name="inImgAdr">Product's image address.</param>
        public Product(
            string inName,
            int inPriceUsd,
            string inCPU,
            string inRAM,
            string inHDD,
            string inVideoCard,
            string inScreen,
            string inImgAdr)
        {
            this.name = inName;
            this.priceUSD = inPriceUsd;
            this.cPU = inCPU;
            this.rAM = inRAM;
            this.hDD = inHDD;
            this.videoCard = inVideoCard;
            this.screen = inScreen;
            this.imgAdr = inImgAdr;
        }

        /// <summary>
        /// Gets or sets product's name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets product's price in USD.
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
        /// Gets or sets product's CPU.
        /// </summary>
        public string CPU
        {
            get
            {
                return this.cPU;
            }

            set
            {
                this.cPU = value;
            }
        }

        /// <summary>
        /// Gets or sets product's RAM.
        /// </summary>
        public string RAM
        {
            get
            {
                return this.rAM;
            }

            set
            {
                this.rAM = value;
            }
        }

        /// <summary>
        /// Gets or sets product's HDD.
        /// </summary>
        public string HDD
        {
            get
            {
                return this.hDD;
            }

            set
            {
                this.hDD = value;
            }
        }

        /// <summary>
        /// Gets or sets product's graphics card.
        /// </summary>
        public string VideoCard
        {
            get
            {
                return this.videoCard;
            }

            set
            {
                this.videoCard = value;
            }
        }

        /// <summary>
        /// Gets or sets product's screen resolution.
        /// </summary>
        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                this.screen = value;
            }
        }

        /// <summary>
        /// Gets or sets product's image address.
        /// </summary>
        public string ImgAdr
        {
            get
            {
                return this.imgAdr;
            }

            set
            {
                this.imgAdr = value;
            }
        }
    }
}