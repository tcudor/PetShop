using FluentValidation.Results;
using PetShop.Data;
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

namespace PetShop.Forms.Clienti
{
    public partial class Adaugare : Form
    {
        private readonly DBContext dbContext;
        public Adaugare()
        {

            InitializeComponent();
            dbContext = new DBContext();
        }
       

        private void button_adauga_Click_1(object sender, EventArgs e)
        {
            var Client = new Client()
            {
                Nume = textBox_nume.Text,
                Prenume = textBox_prenume.Text,
                Telefon = textBox_telefon.Text,
                Email = textBox_email.Text,
                Adresa = textBox_adresa.Text,
                Sex = comboBox_sex.Text,
                DataNastere = dateTimePicker_dataN.Value.Date
            };
            if (Client != null)
            {

                ClientValidator Validator=new ClientValidator();
                ValidationResult results=Validator.Validate(Client);
                IList<ValidationFailure> failures=results.Errors;
                if (!results.IsValid)
                {
                    foreach(ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dbContext.Clienti.Add(Client);
                    dbContext.SaveChanges();
                    this.Close();
                }
            }
            
        }
    }
}
