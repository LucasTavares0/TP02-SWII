using MySql.Data.EntityFramework;
using TP02.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP02.DAO
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ListagemContext : DbContext
    {
        public ListagemContext() : base("ListagemContext")
        {

        }

        public DbSet<BL> Bls { get; set; }

        public DbSet<Container> Containeres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BL>()
            .ToTable("BL");

            modelBuilder.Entity<Container>()
            .ToTable("Container");
        }
    }
}