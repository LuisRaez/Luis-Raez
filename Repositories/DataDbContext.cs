using Luis_Raez.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace Luis_Raez.Repositories
{
    public class DataDbContext : DbContext
    {
        
        

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Boutique.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definición de relaciones y configuración adicional aquí

            // Relación entre Usuario y Pedido (un Usuario puede tener muchos Pedidos)
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Vendedor)
                .WithMany()
                .HasForeignKey(p => p.VendedorId)
                .OnDelete(DeleteBehavior.Restrict); // Opcional: Configuración de eliminación restringida

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Repartidor)
                .WithMany()
                .HasForeignKey(p => p.RepartidorId)
                .OnDelete(DeleteBehavior.Restrict); // Opcional: Configuración de eliminación restringida

            modelBuilder.Entity<Producto>()
           .Property(p => p.Precio)
           .HasColumnType("decimal(18, 2)"); // Esto define un decimal con 18 dígitos en total y 2 decimales

        }
    }
}