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

        private void button3_Click(object sender, EventArgs e)
        {
            FunctionariForm fromular = new FunctionariForm() { };
            fromular.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            var functionar = dbContext.Functionars.FirstOrDefault(x => x.IdFunctionar == 1);
            var functionar = new Functionar()
            {
                FirstName = wfaffa.Text,

            }
            dbContext.Functionars.Add(functionar);
            dbContext.Functionars.Remove(functionar);
            dbContext.SaveChanges();
            //MessageBox.Show(functionar.Phone);
        }
    }
}