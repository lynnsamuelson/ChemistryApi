using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeriodicTableApi.Models
{
    public class ElementContext : DbContext
    {
        public DbSet<Element> Element { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Element>()
                .ToTable("Element")
                .HasKey(c => c.ElementId);

        }

    }
}