using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Socket.Model
{
    public class Product
    {
        private string name;
        private int priceUSD;
        private int priceUAH;
        private string cPU;
        private string rAM;
        private string hDD;
        private string videoCard;
        private string screen;
        private string imgAdr;

        public Product()
        {
            this.name = "N/A";
            this.priceUSD = 0;
            this.priceUAH = 0;
            this.cPU = "N/A";
            this.rAM = "N/A";
            this.hDD = "N/A";
            this.videoCard = "N/A";
            this.screen = "N/A";
            this.imgAdr = string.Empty;
        }

        public Product(
            string inName,
            int inPriceUsd,
            int inPriceUAH,
            string inCPU,
            string inRAM,
            string inHDD,
            string inVideoCard,
            string inScreen)
        {
            this.name = inName;
            this.priceUSD = inPriceUsd;
            this.priceUAH = inPriceUAH;
            this.cPU = inCPU;
            this.rAM = inRAM;
            this.hDD = inHDD;
            this.videoCard = inVideoCard;
            this.screen = inScreen;
        }

        public Product(
            string inName,
            int inPriceUsd,
            int inPriceUAH,
            string inCPU,
            string inRAM,
            string inHDD,
            string inVideoCard,
            string inScreen,
            string inImgAdr)
        {
            this.name = inName;
            this.priceUSD = inPriceUsd;
            this.priceUAH = inPriceUAH;
            this.cPU = inCPU;
            this.rAM = inRAM;
            this.hDD = inHDD;
            this.videoCard = inVideoCard;
            this.screen = inScreen;
            this.imgAdr = inImgAdr;
        }

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