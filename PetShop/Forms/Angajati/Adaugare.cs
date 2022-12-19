﻿using Microsoft.EntityFrameworkCore;
using PetShop.Data;
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
    
    public partial class Adaugare : Form
    {
        private readonly DBContext dbContext;
        public Adaugare()
        {
           
            InitializeComponent();
            dbContext = new DBContext();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            var Angajat = new Angajat()
            {
                FirstName = textBox_nume.Text,
                LastName = textBox_prenume.Text,
                Phone = textBox_telefon.Text,
                Email = textBox_email.Text,
                Adresa = textBox_adresa.Text,
                Sex = textBox_sex.Text,
                DataAngajarii = dateTimePicker_dataA.Value,
                BirthDate=dateTimePicker_dataN.Value
            };
            dbContext.Angajati.Add(Angajat);
            dbContext.SaveChanges();
            ClientiForm form = new ClientiForm() { };
            form.Show();
            this.Close();
        }
    }
}
