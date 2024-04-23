using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace İlan_Sitesi.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
            Database.SetInitializer(new Dataİnitializer());
        }
        public DbSet<Şehir> Şehirs { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Durum> Durums { get; set; }
        public DbSet<İlan> İlans { get; set; }
        public DbSet<Resim> Resims { get; set; }


    }
}