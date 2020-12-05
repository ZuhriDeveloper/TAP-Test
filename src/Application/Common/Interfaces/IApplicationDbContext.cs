using TAP_TEST.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace TAP_TEST.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<TAP_TEST.Domain.Entities.CardPrefix> CardPrefixes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
