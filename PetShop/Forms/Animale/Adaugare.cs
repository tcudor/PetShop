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

namespace PetShop.Forms.Animale
{
    
    public partial class Adaugare : Form
    {
        private readonly DBContext dbContext;
        public Adaugare()
        {
            InitializeComponent();
            dbContext = new DBContext();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            var Animal = new Animal()
            {
                Categorie=textBox_categorie.Text,
                Rasa = textBox_rasa.Text,
                Descriere = textBox_descriere.Text,
                IdCumparator = (int)numericUpDown_id.Value,
                Sex = comboBox_sex.Text,
                DataNastere = dateTimePicker_dataN.Value
            };
            dbContext.Animale.Add(Animal);
            dbContext.SaveChanges();
            this.Close();
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            try
            {
                var client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
                if (client != null)
                {
                    numericUpDown_id.Value = id;
                    button_adauga.Enabled = true;
                }
                else
                {
                    button_adauga.Enabled = false;
                    throw new Exception();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }
    }
}
