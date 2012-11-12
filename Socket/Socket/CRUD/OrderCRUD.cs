// -----------------------------------------------------------------------
// <copyright file="OrderCRUD.cs" company="Microsoft">
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
    public class OrderCRUD : ICRUD<Order>, ITableCRUD<Order>
    {
        private ADO ado = new ADO();

        public Order order
        {
            get;
            private set;
        }

        public List<Order> tablOrder
        {
            get;
            private set;
        }

        public void Create(Order obj)
        {
        }

        public Order Read(string key)
        {
            this.order = new Order();
            return this.order;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
        }

        public void TablCreate(List<Order> obj)
        {
        }

        public List<Order> TablRead()
        {
            DataTable dt = this.ado.GetTablOrder().Tables[0];
            this.tablOrder = new List<Order>();
            this.order = new Order();
            int i = 0;
            string temp = "";
            Card card = new Card();
            foreach (DataRow rows in dt.Rows)
            {
                if (i == 0)
                {
                    i++;
                    temp = rows["number"].ToString();
                }

                Product product = new Product();
                if (rows["number"].ToString() == temp)
                {
                    product.Name = rows["name"].ToString();
                    product.PriceUSD = int.Parse(rows["priceUSD"].ToString());
                    product.RAM = rows["rAM"].ToString();
                    product.HDD = rows["hDD"].ToString();
                    product.CPU = rows["cPU"].ToString();
                    product.Screen = rows["screen"].ToString();
                    product.ImgAdr = rows["imgAdr"].ToString();
                    product.VideoCard = rows["videoCard"].ToString();
                    card.Number = rows["number"].ToString();
                    card.Code = int.Parse(rows["code"].ToString());
                    card.Mounth = rows["mounth"].ToString();
                    card.Year = int.Parse(rows["year"].ToString());
                    this.order.Products.Add(product);
                    switch (rows["StatusOrders.status"].ToString())
                    {
                        case "Pending":
                            {
                                this.order.Status = OrderStatus.Pending;
                                break;
                            }

                        case "Danie":
                            {
                                this.order.Status = OrderStatus.Danie;
                                break;
                            }

                        case "Accepted":
                            {
                                this.order.Status = OrderStatus.Accepted;
                                break;
                            }

                        case "Delivered":
                            {
                                this.order.Status = OrderStatus.Delivered;
                                break;
                            }
                    }
                }
                else
                {
                    this.order.CardData = card;
                    this.tablOrder.Add(this.order);
                    this.order = new Order();
                    card = new Card();
                    temp = rows["number"].ToString();
                    product.Name = rows["name"].ToString();
                    product.PriceUSD = int.Parse(rows["priceUSD"].ToString());
                    product.RAM = rows["rAM"].ToString();
                    product.HDD = rows["hDD"].ToString();
                    product.CPU = rows["cPU"].ToString();
                    product.Screen = rows["screen"].ToString();
                    product.ImgAdr = rows["imgAdr"].ToString();
                    product.VideoCard = rows["videoCard"].ToString();
                    card.Number = rows["number"].ToString();
                    card.Code = int.Parse(rows["code"].ToString());
                    card.Mounth = rows["mounth"].ToString();
                    card.Year = int.Parse(rows["year"].ToString());
                    this.order.Products.Add(product);
                    switch (rows["StatusOrders.status"].ToString())
                    {
                        case "Pending":
                            {
                                this.order.Status = OrderStatus.Pending;
                                break;
                            }

                        case "Danie":
                            {
                                this.order.Status = OrderStatus.Danie;
                                break;
                            }

                        case "Accepted":
                            {
                                this.order.Status = OrderStatus.Accepted;
                                break;
                            }

                        case "Delivered":
                            {
                                this.order.Status = OrderStatus.Delivered;
                                break;
                            }
                    }

                }
            }
            this.tablOrder.Add(this.order);
            return this.tablOrder;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
