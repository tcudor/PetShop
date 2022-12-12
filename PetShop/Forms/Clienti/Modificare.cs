using PetShop.Data;
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
    public partial class Modificare : Form
    {
        private readonly DBContext dbContext;
        public Modificare()
        {
            InitializeComponent();
            dbContext = new DBContext();
        }

        private void button_modifica_Click(object sender, EventArgs e)
        {

            int id = (int)numericUpDown_id.Value;
            var Client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);

            Client.FirstName = textBox_nume.Text;
            Client.LastName = textBox_prenume.Text;
            Client.Phone = textBox_telefon.Text;
            Client.Email = textBox_email.Text;
            Client.Adresa = textBox_adresa.Text;
            Client.Sex = textBox_sex.Text;
            Client.BirthDate = dateTimePicker_dataN.Value;

            dbContext.Clienti.Update(Client);
            dbContext.SaveChanges();
            this.Close();
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
            if (Client != null)
            {
                textBox_nume.Text = Client.FirstName;
                textBox_prenume.Text = Client.LastName;
                textBox_adresa.Text = Client.Adresa;
                textBox_telefon.Text = Client.Phone;
                textBox_email.Text = Client.Email;
                textBox_sex.Text = Client.Sex;
                dateTimePicker_dataN.Value = Client.BirthDate;
            }
            else
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }
    }
}
