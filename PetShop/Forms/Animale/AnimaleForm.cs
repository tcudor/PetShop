using PetShop.Data;
using PetShop.Forms.Clienti;
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

namespace PetShop.Forms.Animale
{
    public partial class AnimaleForm : Form
    {
        private readonly DBContext dbContext;
        private Animal? query;

        public AnimaleForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            var user = dbContext.Users.FirstOrDefault(x => x.Power >= 1);
            if (user == null)
            {
                button_modifica.Enabled = false;
                button_refresh.Enabled = false;
                button_stergere.Enabled = false;
                button_adauga.Enabled = false;

            }
            comboBox_ID.SelectedIndex= 0;
            GetAll();
        }

        private void GetAll()
        {
            BindingSource BS = new BindingSource();
            var query = dbContext.Animale.ToList();
            BS.DataSource = query;
            dataGridView1.DataSource = BS;
            dataGridView1.Refresh();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            AnimaleForm form = new AnimaleForm() { };
            form.Show();
            this.Close();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            Adaugare form = new Adaugare();
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

        private void button_home_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm() { };
            form.Show();
            this.Close();
        }

        private void button_view_animale_Click(object sender, EventArgs e)
        {
            AnimaleForm form = new AnimaleForm() { };
            form.Show();
            this.Close();
        }

        private void button_view_angajati_Click(object sender, EventArgs e)
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource BS = new BindingSource();
            if (comboBox1.Text == "IdAnimal")
            {
                var query = dbContext.Animale.OrderBy(x => x.IdAnimal).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Categorie")
            {
                var query = dbContext.Animale.OrderBy(x => x.Categorie).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Rasa")
            {
                var query = dbContext.Animale.OrderBy(x => x.Rasa).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "Data nastere")
            {
                var query = dbContext.Animale.OrderBy(x => x.DataNastere).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
            if (comboBox1.Text == "IdCumparator")
            {
                var query = dbContext.Animale.OrderBy(x => x.IdCumparator).ToList();
                BS.DataSource = query;
                dataGridView1.DataSource = BS;
                dataGridView1.Refresh();
            }
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            int copie = id;
            try
            {
                var Angajat = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);
                if (Angajat != null)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            BindingSource BS = new BindingSource();
            int id = (int)numericUpDown_id.Value;
            if(comboBox_ID.SelectedIndex==0)    
                query = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);
            else
                query = dbContext.Animale.FirstOrDefault(x => x.IdCumparator == id);
            BS.DataSource = query;
            dataGridView1.DataSource = BS;
            dataGridView1.Refresh();
        }
    }
}
