using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Config
{
    public class DbConfig : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=listaip;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "admin" },
                new Role { Id = 2, RoleName = "tecnico" },
                new Role { Id = 3, RoleName = "monitoramento" }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nome = "admin", Email = "admin@admin.com", Password = "12345", RoleId = 1 }
            );
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Antena> Antenas { get; set; }
        public DbSet<ErroMinitoramento> Erros { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
