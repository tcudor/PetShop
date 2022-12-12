using PetShop.Data;
using PetShop.Forms;
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





        //var Angajat = dbContext.Angajats.FirstOrDefault(x => x.IdAngajat == 1);
        //var Angajat = new Angajat()
        //{
        //    FirstName = wfaffa.Text,

        //}
        //dbContext.Angajats.Add(Angajat);
        //dbContext.Angajats.Remove(Angajat);
        //dbContext.SaveChanges();
        //MessageBox.Show(Angajat.Phone);



    }
}