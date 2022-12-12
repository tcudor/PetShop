using Microsoft.EntityFrameworkCore;
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

namespace PetShop.Forms.Angajati
{
    
    public partial class Modificare : Form
    {
        private readonly DBContext dbContext;
        
        public Modificare()
        {
           
            InitializeComponent();
            dbContext = new DBContext();
            
        }

       

        private void button_modifica_Click(object sender, EventArgs e)
        {

            int id = (int)numericUpDown_id.Value;
            var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);   
            
            Angajat.FirstName = Angajat.FirstName;
            Angajat.LastName = textBox_prenume.Text;
            Angajat.Phone = textBox_telefon.Text;
            Angajat.Email = textBox_email.Text;
            Angajat.Adresa = textBox_adresa.Text;
            Angajat.Sex = textBox_sex.Text;
            Angajat.DataAngajarii = dateTimePicker_dataA.Value;
            Angajat.BirthDate = dateTimePicker_dataN.Value;
           
            dbContext.Angajati.Update(Angajat);
            dbContext.SaveChanges();
            this.Close();

        }
    

        private void numericUpDown_id_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_id.Value;
            var Angajat = dbContext.Angajati.FirstOrDefault(x => x.IdAngajat == id);
            if (Angajat != null)
            {                          
                    textBox_nume.Text = Angajat.FirstName;
                    textBox_prenume.Text = Angajat.LastName;
                    textBox_adresa.Text = Angajat.Adresa;
                    textBox_telefon.Text = Angajat.Phone;
                    textBox_email.Text = Angajat.Email;
                    textBox_sex.Text = Angajat.Sex;
                    dateTimePicker_dataA.Value = Angajat.DataAngajarii;
                    dateTimePicker_dataN.Value = Angajat.BirthDate;
            }
            else
            {
                    MessageBox.Show("Ati introdus un id inexistent");
            }
        }


    }
}
