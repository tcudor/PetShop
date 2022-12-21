using PetShop.Data;
using PetShop.Forms.Angajati;
using PetShop.Forms.Animale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms.Clienti
{
    public partial class ClientiForm : Form
    {
        private readonly DBContext dbContext;
        public ClientiForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            GetAll();
        }

        public void GetAll()
        {
            BindingSource BS = new BindingSource();
            var query = dbContext.Clienti.ToList();
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
            Adaugare form= new Adaugare();
            form.Show();

        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            Modificare form = new Modificare() { };
            form.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            GetAll();
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

        private void button_view_clienti_Click(object sender, EventArgs e)
        {
            ClientiForm form = new ClientiForm() { };
            form.Show();
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource BS = new BindingSource();
            if (comboBox1.Text=="IdClient")
            {               
                var query = dbContext.Clienti.OrderBy(x=>x.IdClient).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Nume")
            {               
                var query = dbContext.Clienti.OrderBy(x => x.Nume).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Prenume")
            {             
                var query = dbContext.Clienti.OrderBy(x => x.Prenume).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Email")
            {
                var query = dbContext.Clienti.OrderBy(x => x.Email).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Telefon")
            {
                var query = dbContext.Clienti.OrderBy(x => x.Telefon).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Adresa")
            {
                var query = dbContext.Clienti.OrderBy(x => x.Adresa).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Data nastere")
            {
                var query = dbContext.Clienti.OrderBy(x => x.DataNastere).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource BS = new BindingSource();
            int id = (int)numericUpDown_id.Value;
            var query = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
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
                var client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
                if (client != null)
                {
                    copie = id;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }

        private void button_refresh_Click_2(object sender, EventArgs e)
        {
            ClientiForm form = new ClientiForm() { };
            form.Show();
            this.Close();
        }

        private void button_view_animale_Click(object sender, EventArgs e)
        {
            AnimaleForm form = new AnimaleForm() { };
            form.Show();
            this.Close();
        }
    }
}
