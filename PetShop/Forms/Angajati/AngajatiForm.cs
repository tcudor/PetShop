using Microsoft.Data.SqlClient;
using PetShop.Data;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Forms.Angajati;

namespace PetShop.Forms
{
    public partial class AngajatiForm : Form
    {
        private readonly DBContext dbContext;
        public AngajatiForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            GetAll();

            
        }

        public void GetAll()
        {
            BindingSource BS= new BindingSource();
            var query = dbContext.Angajati.ToList();
            //var query = dbcontext.Angajats.Select(x => new
            //{
            //    x.IdAngajat,
            //    x.FirstName,
            //    x.LastName,
            //    x.Email,
            //    x.Adresa,
            //    x.Sex,
            //    x.BirthDate,
            //    x.DataAngajarii
            //}).ToList();
            BS.DataSource = query;
            dataGridView1.DataSource=BS;
            dataGridView1.Refresh();

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm() { };
            form.Show();
            this.Close();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            Adaugare form = new Adaugare() { };
            form.Show();
            
        }
    }
}
