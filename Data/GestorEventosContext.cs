using Microsoft.EntityFrameworkCore;
using GestorEventos.Models;
using System;

namespace GestorEventos.Data
{
    public class GestorEventosContext : DbContext
    {
        public GestorEventosContext(DbContextOptions<GestorEventosContext> options)
            : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeo del nombre de la tabla para la entidad Evento
            modelBuilder.Entity<Evento>().ToTable("Eventos");

            // Método para seed data
            SeedData.Initialize(this);
        }
    }

    public static class SeedData
    {
        public static void Initialize(GestorEventosContext context)
        {
            //aca se pueden añadir eventos de prueba si no existe ninguno
        }
    }
}
