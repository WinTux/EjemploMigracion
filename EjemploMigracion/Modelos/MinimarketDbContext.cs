using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploMigracion.Modelos
{
    public class MinimarketDbContext : DbContext
    {
        private const string cadenaCon = 
            "Server=192.168.1.253;Database=MinimarketPaola;User=Pepe;Password=123456";
        public DbSet<Empleado> Empleeados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder op) {
            op.UseSqlServer(cadenaCon);
        }
    }
}
