using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }
        public string Categorie { get; set; } 
        public string Rasa { get; set; }
        public string Descriere { get; set; }
        public string Sex { get; set; }
        public DateTime DataNastere { get; set; }



        [ForeignKey("IdCumparator")]
        public Client Client { get; set; }
        public int IdCumparator { get; set; }
       
       
        


    }
}
