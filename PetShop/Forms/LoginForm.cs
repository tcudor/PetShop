using PetShop.Data;
using PetShop.Forms.Animale;
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
    public partial class LoginForm : Form
    {
        private readonly DBContext dbContext;
        public LoginForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            var query = dbContext.Users.ToList();
            foreach ( var item in query )
            {
                item.Power = false;
                dbContext.Users.Update(item);
                dbContext.SaveChanges();
            }
        }

        private void button_continua_Click(object sender, EventArgs e)
        {
            
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var User = dbContext.Users.First(x => x.Username == textBox1.Text);
            if (User != null)
            {
                if(User.Password==textBox2.Text)
                {
                    User.Power = true;
                    dbContext.Users.Update(User);
                    dbContext.SaveChanges();
                    MainForm form = new MainForm();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Parola Incorecta");
                }
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a fost gasit");
            }
           
        }
    }
}
