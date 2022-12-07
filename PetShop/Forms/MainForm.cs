using PetShop.Forms;

namespace PetShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FunctionariForm fromular = new FunctionariForm() { };
            fromular.Show();
        }
    }
}