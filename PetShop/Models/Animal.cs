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
        public enum Categorie 
        { 
            Mamifer,
            Pasare,
            Peste
        } 
        public string Rasa { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }

        public int IdCumparator { get; set; }
        [ForeignKey("IdCumparator")]
        public Client Client;

    }
}
