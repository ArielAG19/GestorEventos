using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestorEventos.Models;

namespace GestorEventos.Data
{
    public class GestorEventosContext : DbContext
    {
        public GestorEventosContext (DbContextOptions<GestorEventosContext> options)
            : base(options)
        {
        }

        public DbSet<GestorEventos.Models.Evento> Evento { get; set; } = default!;
    }
}
