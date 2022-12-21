using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Angajat
    {
        [Key]
        public int IdAngajat { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Sex { get; set; }
        public DateTime DataNastere { get; set; }
        public DateTime DataAngajare { get; set; }


    }
}
