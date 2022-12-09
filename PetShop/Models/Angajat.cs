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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DataAngajarii { get; set; }

        public enum type 
        {
            Admin,
            Casier,
            Ingrijitor
        }

    }
}
