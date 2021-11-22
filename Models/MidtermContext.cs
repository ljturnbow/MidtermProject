using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MidtermProject.Models
{
    // This class inherits Entity Framework. Gateway to DataBase
    public class MidtermContext : DbContext 
    {
        public MidtermContext() : base("name=MidtermContext")
        {
            
        }
         
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}