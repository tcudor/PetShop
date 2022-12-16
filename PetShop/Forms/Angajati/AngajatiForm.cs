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
using PetShop.Forms.Clienti;
using Stergere = PetShop.Forms.Angajati.Stergere;
using Adaugare = PetShop.Forms.Angajati.Adaugare;
using Modificare = PetShop.Forms.Angajati.Modificare;

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

        private void button_modifica_Click(object sender, EventArgs e)
        {
            Modificare form = new Modificare() { };
            form.Show();
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            Stergere form = new Stergere() { };
            form.Show();
        }

        private void button_view_angajati_Click(object sender, EventArgs e)
        {
            AngajatiForm form = new AngajatiForm() { };
            form.Show();
            this.Close();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            AngajatiForm form = new AngajatiForm() { };
            form.Show();
            this.Close();
        }

        private void button_view_clienti_Click(object sender, EventArgs e)
        {
            ClientiForm form = new ClientiForm() { };
            form.Show();
            this.Close();
        }
    }
}
