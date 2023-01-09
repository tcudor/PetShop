using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Power { get; set; }
    }
}
