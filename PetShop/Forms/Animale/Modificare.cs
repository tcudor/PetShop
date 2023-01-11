using PetShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms.Animale
{
    public partial class Modificare : Form
    {
        private readonly DBContext dbContext;

        public Modificare()
        {
            InitializeComponent();
            dbContext = new DBContext();
            button_modifica.Enabled = false;
        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Animal = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);

            Animal.Categorie=textBox_categorie.Text;
            Animal.Rasa = textBox_rasa.Text;
            Animal.Descriere = textBox_descriere.Text;
            Animal.IdCumparator = (int)numericUpDown_idcumparator.Value;
            Animal.Sex = comboBox_sex.Text;
            Animal.DataNastere = dateTimePicker_dataN.Value.Date;
        
            dbContext.Animale.Update(Animal);
            dbContext.SaveChanges();
            this.Close();
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Animal = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);
            try
            {

                if (Animal != null)
                {
                    textBox_rasa.Text = Animal.Rasa;
                    textBox_descriere.Text = Animal.Descriere;
                    textBox_categorie.Text = Animal.Categorie;
                    numericUpDown_idcumparator.Value = Animal.IdCumparator;
                    comboBox_sex.Text = Animal.Sex;
                    dateTimePicker_dataN.Value = Animal.DataNastere;
                    button_modifica.Enabled = true;
                }
                else
                {
                    button_modifica.Enabled = false;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }

        private void numericUpDown_idcumparator_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            try
            {
                var client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
                if (client != null)
                {
                    numericUpDown_id.Value = id;
                    button_modifica.Enabled = true;
                }
                else
                {
                    throw new Exception();
                    button_modifica.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }
    }
}
