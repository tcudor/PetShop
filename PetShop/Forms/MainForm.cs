using PetShop.Data;
using PetShop.Forms;
using PetShop.Forms.Animale;
using PetShop.Forms.Clienti;
using PetShop.Models;
using System.Windows.Forms.VisualStyles;

namespace PetShop
{
    public partial class MainForm : Form
    {
        private readonly DBContext dbContext;
        public MainForm()
        {
            InitializeComponent();
            dbContext = new DBContext();
            var user = dbContext.Users.FirstOrDefault(x => x.Power == 2);
            if (user == null)
            {
                button_adduser.Visible = false;
            }
            else
            {
                button_adduser.Visible = true;
            }
        }

        private void button_view_angajati_Click(object sender, EventArgs e)
        {
            AngajatiForm form = new AngajatiForm() { };
            form.Show();
            this.Close();
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_view_clienti_Click(object sender, EventArgs e)
        {
            ClientiForm form = new ClientiForm();
            form.Show();
            this.Close();
        }

        private void button_view_animale_Click(object sender, EventArgs e)
        {
            AnimaleForm form = new AnimaleForm();
            form.Show();
            this.Close();
        }

       

        private void button_adduser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.Show();
        }
    }
}