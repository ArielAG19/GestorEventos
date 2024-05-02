using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using GestorEventos.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestorEventos.Data
{
    public interface IGestorEventosContext
    {
        DbSet<Evento> Eventos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
