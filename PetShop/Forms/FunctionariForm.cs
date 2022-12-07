using Microsoft.Data.SqlClient;
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
    public partial class FunctionariForm : Form
    {
        private DBContext dbcontext;
        SqlConnection con=new SqlConnection( @"Server=(localdb)\MSSQLLocalDB;Database=PetShopDB;Trusted_Connection=True");
        SqlDataAdapter adapt;
        public FunctionariForm()
        {
            InitializeComponent();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Functionars", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       
    }
}
