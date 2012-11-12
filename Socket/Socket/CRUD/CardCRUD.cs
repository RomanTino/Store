// -----------------------------------------------------------------------
// <copyright file="CardCRUD.cs" company="Microsoft">
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
    public class CardCRUD : ICRUD<Card>, ITableCRUD<Card>
    {
        private ADO ado = new ADO();

        public Card card
        {
            get;
            private set;
        }

        public List<Card> tablCard
        {
            get;
            private set;
        }

        public void Create(Card obj)
        {
            this.ado.InsertCard(obj.Number, obj.Code.ToString(), obj.Mounth, obj.Year.ToString());
        }

        public Card Read(string key)
        {
            DataTable dt = this.ado.GetTablCard().Tables[0];
            this.card = new Card();
            foreach (DataRow rows in dt.Rows)
            {
                if (rows["number"].ToString() == key)
                {
                    this.card.Number = key;
                    this.card.Code = int.Parse(rows["code"].ToString());
                    this.card.Mounth = rows["mounth"].ToString();
                    this.card.Year = int.Parse(rows["year"].ToString());
                    this.tablCard.Add(this.card);
                }
            }

            return this.card;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
            this.ado.Delete("Cards", "number", key);
        }

        public void TablCreate(List<Card> obj)
        {
        }

        public List<Card> TablRead()
        {
            DataTable dt = this.ado.GetTablCard().Tables[0];
            this.tablCard = new List<Card>();
            foreach (DataRow rows in dt.Rows)
            {
                this.card = new Card();
                this.card.Number = rows["number"].ToString();
                this.card.Code = int.Parse(rows["code"].ToString());
                this.card.Mounth = rows["mounth"].ToString();
                this.card.Year = int.Parse(rows["year"].ToString());
                this.tablCard.Add(this.card);
            }

            return this.tablCard;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
