using Microsoft.EntityFrameworkCore;
using GestorEventos.Models;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestorEventos.Data
{
    public class GestorEventosContext : DbContext, IGestorEventosContext
    {
        public GestorEventosContext(DbContextOptions<GestorEventosContext> options)
            : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; } = default!;

        // Implementación del método SaveChangesAsync de DbContext
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        // Implementación del método Entry de IGestorEventosContext
        public EntityEntry<T> Entry<T>(T entity) where T : class
        {
            return base.Entry(entity);
        }

        // Otras implementaciones de métodos o propiedades de la interfaz IGestorEventosContext
        // Aquí puedes añadir cualquier otro método o propiedad requerido por la interfaz
    }

    public static class SeedData
    {
        public static void Initialize(GestorEventosContext context)
        {
            //aca se pueden añadir eventos de prueba si no existe ninguno
        }
    }
}
