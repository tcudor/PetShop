﻿using PetShop.Data;
using PetShop.Forms.Clienti;
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

namespace PetShop.Forms.Angajati
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
                var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);
                if (Angajat != null)
                {
                    dbContext.Angajati.Remove(Angajat);
                    dbContext.SaveChanges();
                    AngajatiForm form = new AngajatiForm() { };
                    form.Show();
                    this.Close();
                    button_stergere.Enabled = true;
                }
                else
                {
                    button_stergere.Enabled = false;
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

