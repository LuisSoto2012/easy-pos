// IApplicationDbContext.cs04:0704:07

using Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }

    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
}