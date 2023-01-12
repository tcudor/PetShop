using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Forms.Clienti;
using PetShop.Models;
using PetShop.Validator;
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
                Nume = textBox_nume.Text,
                Prenume = textBox_prenume.Text,
                Telefon = textBox_telefon.Text,
                Email = textBox_email.Text,
                Adresa = textBox_adresa.Text,
                Sex = comboBox_sex.Text,
                DataAngajare = dateTimePicker_dataA.Value,
                DataNastere=dateTimePicker_dataN.Value.Date
            };
            if (Angajat != null)
            {

                AngajatValidator Validator = new AngajatValidator();
                ValidationResult results = Validator.Validate(Angajat);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dbContext.Angajati.Add(Angajat);
                    dbContext.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
