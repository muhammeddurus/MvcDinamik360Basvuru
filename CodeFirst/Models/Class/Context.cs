using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.Class
{
    public class Context : DbContext
    {
        public DbSet<musteri> musteris { get; set; }
        public DbSet<AdminDinamik> AdminDinamiks { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<musteri>()
                .MapToStoredProcedures();
        }

       
    }    
}