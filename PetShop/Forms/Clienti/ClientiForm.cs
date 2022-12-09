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
    public partial class ClientiForm : Form
    {
        private readonly DBContext dbcontext;
        public ClientiForm()
        {
            InitializeComponent();
            dbcontext = new DBContext();
            GetAll();

            
        }

        public void GetAll()
        {
            BindingSource BS= new BindingSource();
            var query = dbcontext.Clients.ToList();
            //var query = dbcontext.Functionars.Select(x => new
            //{
            //    x.IdFunctionar,
            //    x.FirstName,
            //    x.LastName,
            //    x.Email,
            //    x.Adresa,
            //    x.Sex,
            //    x.BirthDate,
            //    x.DataAngajarii
            //}).ToList();
            BS.DataSource = query;
            dataGridView1.DataSource=BS;
            dataGridView1.Refresh();

        }
       
    }
}
