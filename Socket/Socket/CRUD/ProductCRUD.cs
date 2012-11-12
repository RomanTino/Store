// -----------------------------------------------------------------------
// <copyright file="ProductCRUD.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.CRUD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using Socket.ICRUD;
    using Socket.Model;
    using Socket.ADO;
    using Socket.ITableCRUD;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ProductCRUD : ICRUD<Product>, ITableCRUD<Product>
    {
        private ADO ado = new ADO();

        public Product product
        {
            get;
            private set;
        }

        public List<Product> tablProduct
        {
            get;
            private set;
        }

        public void Create(Product obj)
        {
            this.ado.InsertProduct(obj.Name, obj.PriceUSD.ToString(), obj.RAM, obj.HDD, obj.CPU, obj.Screen, obj.VideoCard, obj.ImgAdr);
        }

        public Product Read(string key)
        {
            this.product = new Product();
            DataTable dt = this.ado.GetTablProduct().Tables[0];
            foreach (DataRow rows in dt.Rows)
            {
                if (rows["name"].ToString() == key)
                {
                    this.product.Name = key;
                    this.product.PriceUSD = int.Parse(rows["priceUSD"].ToString());
                    this.product.RAM = rows["rAM"].ToString();
                    this.product.HDD = rows["hDD"].ToString();
                    this.product.CPU = rows["cPU"].ToString();
                    this.product.Screen = rows["screen"].ToString();
                    this.product.ImgAdr = rows["imgAdr"].ToString();
                    this.product.VideoCard = rows["videoCard"].ToString();
                    break;
                }
            }

            return this.product;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
            this.ado.Delete("Products", "name", key);
        }

        public void TablCreate(List<Product> obj)
        {
        }

        public List<Product> TablRead()
        {
            DataTable dt;
            dt = this.ado.GetTablProduct().Tables[0];
            this.tablProduct = new List<Product>(); ////!!!!!!!!!!!!!!!!!
            foreach (DataRow rows in dt.Rows)
            {
                this.product = new Product();
                this.product.Name = rows["name"].ToString();
                this.product.PriceUSD = int.Parse(rows["priceUSD"].ToString());
                this.product.RAM = rows["rAM"].ToString();
                this.product.HDD = rows["hDD"].ToString();
                this.product.CPU = rows["cPU"].ToString();
                this.product.Screen = rows["screen"].ToString();
                this.product.ImgAdr = rows["imgAdr"].ToString();
                this.product.VideoCard = rows["videoCard"].ToString();
                this.tablProduct.Add(this.product);
            }

            return this.tablProduct;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
