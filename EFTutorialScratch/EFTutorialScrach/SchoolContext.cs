using EF6CodeFirstTutorials;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorialScrach
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base(new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EFTutorialScrach.SchoolContext;Integrated Security=True;MultipleActiveResultSets=True"), true)
        //public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
