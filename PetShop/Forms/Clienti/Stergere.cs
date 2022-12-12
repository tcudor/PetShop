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
    public partial class Stergere : Form
    {
        private readonly DBContext dbContext;
        public Stergere()
        {
            InitializeComponent();
            dbContext = new DBContext();
        }

        private void button_stergere_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
            if (Client != null)
            {
                dbContext.Clienti.Remove(Client);
                dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ati introdus un id inexistent");
            }
        }
    }
}
