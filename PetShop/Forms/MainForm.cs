using PetShop.Data;
using PetShop.Forms;
using PetShop.Models;

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

        private void button_view_angajati_Click (object sender, EventArgs e)
        {
            FunctionariForm form = new FunctionariForm() { };
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //var functionar = dbContext.Functionars.FirstOrDefault(x => x.IdFunctionar == 1);
            //var functionar = new Functionar()
            //{
            //    FirstName = wfaffa.Text,

            //}
            //dbContext.Functionars.Add(functionar);
            //dbContext.Functionars.Remove(functionar);
            //dbContext.SaveChanges();
            //MessageBox.Show(functionar.Phone);
        }
    }
}