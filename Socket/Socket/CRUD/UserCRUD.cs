// -----------------------------------------------------------------------
// <copyright file="UserCRUD.cs" company="Microsoft">
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
    public class UserCRUD : ICRUD<User>, ITableCRUD<User>
    {
        private ADO ado = new ADO();

        public User user
        {
            get;
            private set;
        }

        public List<User> tablUser
        {
            get;
            private set;
        }

        public void Create(User obj)
        {
        }

        public User Read(string key)
        {
            this.user = new User();
            return this.user;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
        }

        public void TablCreate(List<User> obj)
        {
        }

        public List<User> TablRead()
        {
            DataTable dt = this.ado.GetTablUser().Tables[0];
            this.tablUser = new List<User>();
            foreach (DataRow rows in dt.Rows)
            {
                this.user = new User();
                this.user.PriceUAH = int.Parse(rows["priceUAH"].ToString());
                this.user.PriceUSD = int.Parse(rows["priceUSD"].ToString());
                this.user.Status = (UserStatus)rows["Users.status"];
                Person person = new Person();
                person.Name = rows["name"].ToString();
                person.Surname = rows["surname"].ToString();
                person.Nick = rows["nick"].ToString();
                person.Password = rows["password"].ToString();
                person.PhoneNumber = rows["phoneNumber"].ToString();
                person.Status = (PersonStatus)rows["Persons.status"];
                person.Email = rows["mail"].ToString();
                this.user.PersonData = person;
                this.tablUser.Add(this.user);
            }

            return this.tablUser;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
