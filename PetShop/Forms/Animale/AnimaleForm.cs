using PetShop.Data;
using PetShop.Forms.Clienti;
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
        public AnimaleForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
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
    }
}
