// -----------------------------------------------------------------------
// <copyright file="ADO.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.ADO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ADO
    {
        private static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Socket.adp.mdb)-0 - ОстанняВерсія.mdb";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            return conn;
        }

        private static void CloseConnection(OleDbConnection conn)
        {
            conn.Close();
        }

        public DataSet GetTablPerson()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Persons ", conn);
            da.Fill(ds, "Persons");
            conn.Close();
            return ds;
        }

        public DataSet GetTablUser()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Persons INNER JOIN Users ON Persons.IDPerson = Users.person", conn);
            da.Fill(ds, "Users");
            conn.Close();
            return ds;
        }

        public DataSet GetTablStaff()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Persons INNER JOIN Staffs ON Persons.IDPerson = Staffs.person", conn);
            da.Fill(ds, "Staffs");
            conn.Close();
            return ds;
        }

        public DataSet GetTablCard()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Cards ", conn);
            da.Fill(ds, "Cards");
            conn.Close();
            return ds;
        }

        public DataSet GetTablOrder()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Products INNER JOIN (Cards INNER JOIN (StatusOrders INNER JOIN Orders ON StatusOrders.IDStatusPayment = Orders.status) ON Cards.IDCard = Orders.card) ON Products.IDProduct = Orders.product ORDER BY Cards.Number", conn);
            da.Fill(ds, "Orders");
            conn.Close();
            return ds;
        }

        public DataSet GetTablPayment()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM StatusOrders INNER JOIN (Cards INNER JOIN (Products INNER JOIN (Users INNER JOIN (Orders INNER JOIN Payments ON Orders.IDOrder = Payments.order) ON Users.IDUser = Payments.user) ON Products.IDProduct = Orders.product) ON Cards.IDCard = Orders.card) ON StatusOrders.IDStatusPayment = Orders.status ORDER BY Users.person, Cards.Number", conn);
            da.Fill(ds, "Payments");
            conn.Close();
            return ds;
        }

        public DataSet GetTablProduct()
        {
            DataSet ds = new DataSet();
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Products ", conn);
            da.Fill(ds, "Products");
            conn.Close();
            return ds;
        }

        /// <summary>
        /// Delete row from table 'tableName' where fild keyName = key
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyName"></param>
        /// <param name="key"></param>
        public void Delete(string tableName, string keyName, string key)
        {
            OleDbConnection conn = GetConnection();
            string sql = string.Format("Delete from {0} where {1} = '{2}'", tableName, keyName, key);
            using (OleDbCommand comand = new OleDbCommand(sql, conn))
            {
                try
                {
                    comand.ExecuteNonQuery();
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    string st = string.Format("There is no row in {0} with {1} = '{2}'.", tableName, keyName, key);
                    Exception error = new Exception(st, ex);
                    throw error;
                }
            }
        }

        //public void Insert(string tableName, string[] attributsName, string[] attributsValue)
        //{
        //    string sql = string.Format("Insert Into '{0}'(", tableName);
        //    for (int i = 0; i < attributsName.Length - 1; i++ )
        //    {
        //        sql += attributsName[i] + ", ";
        //            string.Format("Insert Into '{0}'(CarID, Make, Color, PetName) Values('{0}','{1}','{2}','{3}')", tableName, keyName, key);
        //    }
        //    sql += attributsName[attributsName.Length] + ") Values(;


        //    OleDbConnection conn = GetConnection();

        //    using (OleDbCommand comand = new OleDbCommand(sql, conn))
        //    {
        //        try
        //        {
        //            comand.ExecuteNonQuery();
        //            conn.Close();
        //        }
        //        catch (OleDbException ex)
        //        {
        //            string st = string.Format("There is no row in {0} with {1} = '{2}'.", tableName, keyName, key);
        //            Exception error = new Exception(st, ex);
        //            throw error;
        //        }
        //    }
        //}

        public void InsertPerson(string name, string surname, string password, string nick, string phoneNumber, string mail, string status)
        {
            OleDbConnection conn = GetConnection();
            string sql = string.Format("Insert Into Persons(name, surname, password, nick, phoneNumber, mail) Values('{0}','{1}','{2}','{3}','{4}','{5}').", name, surname, password, nick, phoneNumber, mail);
            using (OleDbCommand comand = new OleDbCommand(sql, conn))
            {
                //try
                //{
                comand.ExecuteNonQuery();
                conn.Close();
                //}
                //catch (OleDbException ex)
                //{
                //    string st = string.Format("There is no row in {0} with {1} = '{2}'.", tableName, keyName, key);
                //    Exception error = new Exception(st, ex);
                //    throw error;
                //}
            }
        }

        public void InsertProduct(string name, string priceUSD, string rAM, string hDD, string cPU, string screen, string videoCard, string imgAdr)
        {
            OleDbConnection conn = GetConnection();
            string sql = string.Format("Insert Into Products(name, priceUSD, rAM, hDD, cPU, screen, videoCard, imgAdr) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", name,  priceUSD, rAM, hDD, cPU, screen, videoCard, imgAdr);
            using (OleDbCommand comand = new OleDbCommand(sql, conn))
            {
                comand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void InsertCard(string number, string code, string mounth, string year)
        {
            OleDbConnection conn = GetConnection();
            string sql = string.Format("Insert Into Cards(number, code, mounth, year) Values('{0}','{1}','{2}','{3}')", number, code, mounth, year);
            using (OleDbCommand comand = new OleDbCommand(sql, conn))
            {
                comand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
