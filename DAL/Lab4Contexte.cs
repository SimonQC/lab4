using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4A.BLL.Domaine;
using Microsoft.EntityFrameworkCore;

namespace Lab4A.DAL
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

        public DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
