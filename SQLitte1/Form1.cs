using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLitte1
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            //people.Add( new PersonModel { FirstName = "Hien", LastName = "Duc" } );
            //people.Add( new PersonModel { FirstName = "Vu", LastName = "Xuan" } );
            people = SQLiteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            lb_person.DataSource = null;
            lb_person.DataSource = people;
            lb_person.DisplayMember = "Fullname";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = txt_firstname.Text;
            p.LastName = txt_lastname.Text;

            //people.Add( p );
            //WireUpPeopleList();
            SQLiteDataAccess.SavePerson(p);

            txt_firstname.Text = "";
            txt_lastname.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}
