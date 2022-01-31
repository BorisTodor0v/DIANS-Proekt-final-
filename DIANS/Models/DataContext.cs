using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DIANS.Models
{
    public class DataContext: DbContext
    {
        public DbSet<restaurant> restaurants { get; set; }
        public DbSet<bars> bars { get; set; }
        public DataContext(): base("DefaultConnection") { }
        public static DataContext Create()
        {
            return new DataContext();
        }
    }
}