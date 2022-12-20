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
            try
            {
                var Client = dbContext.Clienti.FirstOrDefault(x => x.IdClient == id);
                if (Client != null)
                {
                    dbContext.Clienti.Remove(Client);
                    dbContext.SaveChanges();
                    ClientiForm form = new ClientiForm() { };
                    form.Show();
                    this.Close();
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
    }
}
