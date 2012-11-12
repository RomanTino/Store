// -----------------------------------------------------------------------
// <copyright file="PersonCRUD.cs" company="Microsoft">
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
    /// клас похідний від двох інтерфесів круд і крудтаблиці які
    /// мабть методи створити, зчитати, додати, видалити відповідно курд 
    /// має просто рядок додавати а круд тайб таблицю цілу вже ну і зчитувати..
    public class PersonCRUD : ICRUD<Person>, ITableCRUD<Person>
    {
        private ADO ado = new ADO();

        public Person person
        {
            get;
            private set;
        }

        public List<Person> tablPerson
        {
            get;
            private set;
        }

        // Методи круд сворити рядок в таблиці з відповідною персоною
        public void Create(Person obj)
        {
            string status = "1";//obj.Status.ToString();//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            this.ado.InsertPerson(obj.Name, obj.Surname, obj.Password, obj.Nick, obj.PhoneNumber, obj.Email, status);
        }

        // Методи круд зчитати рядок в таблиці з відповідним ключем
        public Person Read(string key)
        {
            this.person = new Person();
            DataTable dt = this.ado.GetTablPerson().Tables[0];
            foreach (DataRow rows in dt.Rows)
            {
                if (rows["nick"].ToString() == key)
                {
                    this.person.Name = rows["name"].ToString(); // записує у відповідне поле класу персона значення в рядку з такою назвою як параметр
                    this.person.Surname = rows["surname"].ToString();
                    this.person.Nick = key;
                    this.person.Password = rows["password"].ToString();
                    this.person.PhoneNumber = rows["phoneNumber"].ToString();
                    this.person.Status = (PersonStatus)rows["status"];
                    this.person.Email = rows["mail"].ToString();
                    this.tablPerson.Add(this.person);
                }
            }

            return this.person;
        }

        // Методи круд змінити рядок в таблиці з відповідним ключем
        public void Update(string key)
        {
        }

        // Методи круд видалити рядок в таблиці з відповідним ключем
        public void Delete(string key)
        {
            this.ado.Delete("Persons", "nick", key);
        }

        // Методи круд табл теж саме що і круд але створює таблиці 
        public void TablCreate(List<Person> obj)
        {

        }

        // Методи круд табл який би мав зчиатти таблицю за допомогою дата сет пробігтись по рядках
        public List<Person> TablRead()
        {
            DataTable dt = this.ado.GetTablPerson().Tables[0];
            this.tablPerson = new List<Person>();
            // малоб по всіх пробігтись але мені щось то не виходить рядках
            foreach (DataRow rows in dt.Rows)
            {
                this.person = new Person();
                this.person.Name = rows["name"].ToString(); // записує у відповідне поле класу персона значення в рядку з такою назвою як параметр
                this.person.Surname = rows["surname"].ToString();
                this.person.Nick = rows["nick"].ToString();
                this.person.Password = rows["password"].ToString();
                this.person.PhoneNumber = rows["phoneNumber"].ToString();
                this.person.Status = (PersonStatus)rows["status"];
                this.person.Email = rows["mail"].ToString();
                this.tablPerson.Add(this.person);
            }
            return this.tablPerson;
        }

        public void TablUpdate()
        {
        }

        public void TablDelete()
        {
        }
    }
}
