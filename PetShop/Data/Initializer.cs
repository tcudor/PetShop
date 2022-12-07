using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data
{
    public class Initializer : IInitializer
    {
        private DBContext DB;

        public Initializer(DBContext dbcontext)
        {
              DB= dbcontext;
        }


        public void Init()
        {
            try
            {
                if (DB.Database.GetPendingMigrations().Count() > 0)
                {
                    DB.Database.Migrate();
                }
            }
            catch 
            {
                MessageBox.Show("MigrareError");
            }
            return;
        }
    }
}
