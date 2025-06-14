using System.Collections;
using Microsoft.EntityFrameworkCore;

public class ReadonlyRepository<T> : IReadonlyRepository<T> where T : BaseEntity
{
  public readonly DbSet<T> Collection;

  public ReadonlyRepository(AppDbContext dbContext) => Collection = dbContext.Set<T>();

  public async Task<T> GetByIdAsync(int id)
    => await Collection.FirstOrDefaultAsync(record => record.Id == id);

  public async Task<IEnumerable<T>> GetAllAsync() => await Collection.ToListAsync();
}