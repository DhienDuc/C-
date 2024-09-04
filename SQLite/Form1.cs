using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite
{
    public partial class Form1 : Form
    {
        List<PersonModel> person = new List<PersonModel> ();
        public Form1()
        {
            InitializeComponent();
            LoadPerson();
        }
        private void LoadPerson()
        {
            person = AccessSQLiteDB.LoadPersonn();
            WriteDataListBox();
        }
        private void WriteDataListBox()
        {
            lb_person.DataSource = null;
            lb_person.DataSource = person;
            lb_person.DisplayMember = "FullName";
        }
        private void InsertPerson(PersonModel person)
        {
            AccessSQLiteDB.InsertPerson(person);
            LoadPerson();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.Name = tb_name.Text;
            p.Family = tb_family.Text;
            InsertPerson(p);
        }
    }
}
