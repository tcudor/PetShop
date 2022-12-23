using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    [Keyless]
    public class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Power { get; set; }
    }
}
