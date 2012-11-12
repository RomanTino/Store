// -----------------------------------------------------------------------
// <copyright file="PaymentCRUD.cs" company="Microsoft">
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
    public class PaymentCRUD : ICRUD<Payment>, ITableCRUD<Payment>
    {
        private ADO ado = new ADO();

        public Payment payment
        {
            get;
            private set;
        }

        public List<Payment> tablPayment
        {
            get;
            private set;
        }

        public void Create(Payment obj)
        {
        }

        public Payment Read(string key)
        {
            this.payment = new Payment();
            return this.payment;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
            this.ado.Delete("Payment", "user", key);
        }

        public void TablCreate(List<Payment> obj)
        {
        }

        public List<Payment> TablRead()
        {
            DataTable dt = this.ado.GetTablPayment().Tables[0];
            this.payment = new Payment();
            this.tablPayment = new List<Payment>();
            foreach (DataRow rows in dt.Rows)
            {
            }

            return this.tablPayment;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
