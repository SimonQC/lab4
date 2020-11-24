using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab4A.Models;

namespace Lab4A.Models
{
	public class Lab4Contexte : DbContext
    {
        public Lab4Contexte(DbContextOptions<Lab4Contexte> options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur>().HasKey(u => u.IdUtilisateur);
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
