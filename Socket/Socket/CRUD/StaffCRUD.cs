// -----------------------------------------------------------------------
// <copyright file="StaffCRUD.cs" company="Microsoft">
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
    public class StaffCRUD : ICRUD<Staff>, ITableCRUD<Staff>
    {
        private ADO ado = new ADO();

        public Staff staff
        {
            get;
            private set;
        }

        public List<Staff> tablStaff
        {
            get;
            private set;
        }

        public void Create(Staff obj)
        {
        }

        public Staff Read(string key)
        {
            DataTable dt = this.ado.GetTablCard().Tables[0];
            foreach (DataRow rows in dt.Rows)
            {
                this.staff = new Staff();
                this.tablStaff = new List<Staff>();
                this.staff.Status = (StaffStatus)rows["status"];
                //???????
                //this.staff.PersonData = 
            }

            return this.staff;
        }

        public void Update(string key)
        {
        }

        public void Delete(string key)
        {
        }

        public void TablCreate(List<Staff> obj)
        {

        }

        public List<Staff> TablRead()
        {
            DataTable dt = this.ado.GetTablStaff().Tables[0];
            this.tablStaff = new List<Staff>();
            foreach (DataRow rows in dt.Rows)
            {
                this.staff = new Staff();
                this.staff.Status = (StaffStatus)rows["Staffs.status"];
                Person person = new Person();
                person.Name = rows["name"].ToString();
                person.Surname = rows["surname"].ToString();
                person.Nick = rows["nick"].ToString();
                person.Password = rows["password"].ToString();
                person.PhoneNumber = rows["phoneNumber"].ToString();
                person.Status = (PersonStatus)rows["Persons.status"];
                person.Email = rows["mail"].ToString();
                this.staff.PersonData = person;
                this.tablStaff.Add(this.staff);
            }

            return this.tablStaff;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
