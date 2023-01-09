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

namespace PetShop.Forms
{
    public partial class AddUserForm : Form
    {
        private readonly DBContext dbContext;

        public AddUserForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Username = textBox_username.Text,
                Password = textBox_parola.Text,
                Power = (int)numericUpDown1.Value
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            this.Close();
            
        }
    }
}
