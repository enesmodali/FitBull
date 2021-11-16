using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class FitBullDbInitilizer : DropCreateDatabaseAlways<FitBullDbContext>
    {
        protected override void Seed(FitBullDbContext context)
        {
            
        }


    }
}
