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
    public partial class Stergere : Form
    {
        private readonly DBContext dbContext;
        public Stergere()
        {
            InitializeComponent();
            dbContext = new DBContext();
            button_stergere.Enabled = false;
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Animal = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);
            dbContext.Animale.Remove(Animal);
            dbContext.SaveChanges();
            this.Close();
        }

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            try
            {
                var Animal = dbContext.Animale.FirstOrDefault(x => x.IdAnimal == id);
                if (Animal != null)
                {
                    button_stergere.Enabled = true;
                }
                else
                {
                    button_stergere.Enabled = false;
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
