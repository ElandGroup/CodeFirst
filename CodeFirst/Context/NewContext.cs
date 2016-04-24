using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Domain;

namespace CodeFirst.Context
{
    public class NewContext:DbContext
    {
        public DbSet<NewType> NewTypes { get; set; }
    }
}
