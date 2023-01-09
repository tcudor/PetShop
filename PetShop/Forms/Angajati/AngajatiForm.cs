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
            var user = dbContext.Users.FirstOrDefault(x => x.Power == 0);
            if (user == null)
            {
                button_modifica.Enabled = false;
                button_refresh.Enabled = false;
                button_stergere.Enabled = false;
                button_adauga.Enabled = false;
                comboBox1.Enabled = false;
                numericUpDown_id.Enabled = false;
                button1.Enabled = false;
            }
            GetAll();


        }

        public void GetAll()
        {

            BindingSource BS = new BindingSource();
            var query = dbContext.Angajati.ToList();
            BS.DataSource = query;
            dataGridView1.DataSource = BS;
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
            AngajatiForm form = new AngajatiForm() { };
            form.Show();
            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource BS = new BindingSource();
            if (comboBox1.Text == "IdAngajat")
            {
                var query = dbContext.Angajati.OrderBy(x => x.IdAngajat).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
           
            if (comboBox1.Text == "Nume")
            {
                var query = dbContext.Angajati.OrderBy(x => x.Nume).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Prenume")
            {
                var query = dbContext.Angajati.OrderBy(x => x.Prenume).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Email")
            {
                var query = dbContext.Angajati.OrderBy(x => x.Email).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Telefon")
            {
                var query = dbContext.Angajati.OrderBy(x => x.Telefon).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Adresa")
            {
                var query = dbContext.Angajati.OrderBy(x => x.Adresa).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Data nastere")
            {
                var query = dbContext.Angajati.OrderBy(x => x.DataNastere).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Data angajare")
            {
                var query = dbContext.Angajati.OrderBy(x => x.DataAngajare).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource BS = new BindingSource();
            int id = (int)numericUpDown_id.Value;
            var query = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);
            BS.DataSource = query;
            dataGridView1.DataSource = BS;
            dataGridView1.Refresh();
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            int copie = id;
            try
            {
                var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);
                if (Angajat != null)
                {
                    copie = id;
                }
                else
                {
                    throw new Exception() ;
                }
            }
            catch (Exception) 
            { 
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }
    }
}
