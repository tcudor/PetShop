using FluentValidation.Results;
using Microsoft.Data.SqlClient;
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms.Angajati
{
    
    public partial class Modificare : Form
    {
        private readonly DBContext dbContext;
        
        public Modificare()
        {
           
            InitializeComponent();
            dbContext = new DBContext();
            button_modifica.Enabled = false;

        }

       

        private void button_modifica_Click(object sender, EventArgs e)
        {

            int id = (int)numericUpDown_id.Value;
            var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);   
            
            Angajat.Nume = textBox_nume.Text;
            Angajat.Prenume = textBox_prenume.Text;
            Angajat.Telefon = textBox_telefon.Text;
            Angajat.Email = textBox_email.Text;
            Angajat.Adresa = textBox_adresa.Text;
            Angajat.Sex = comboBox_sex.Text;
            Angajat.DataAngajare = dateTimePicker_dataA.Value;
            Angajat.DataNastere = dateTimePicker_dataN.Value.Date;
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
                    dbContext.Angajati.Update(Angajat);
                    dbContext.SaveChanges();
                    this.Close();
                }
            }

        }
    

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            try
            {
                var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);
                if (Angajat != null)
                {
                    button_modifica.Enabled = true;
                    textBox_nume.Text = Angajat.Nume;
                    textBox_prenume.Text = Angajat.Prenume;
                    textBox_adresa.Text = Angajat.Adresa;
                    textBox_telefon.Text = Angajat.Telefon;
                    textBox_email.Text = Angajat.Email;
                    comboBox_sex.Text = Angajat.Sex;
                    dateTimePicker_dataA.Value = Angajat.DataAngajare;
                    dateTimePicker_dataN.Value = Angajat.DataNastere;
                }
                else
                {
                    button_modifica.Enabled = false;
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
