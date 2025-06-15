using Microsoft.EntityFrameworkCore;

public class WritableRepository<T> : IWritableRepository<T> where T : BaseEntity
{
  public readonly DbSet<T> Collection;
  protected readonly AppDbContext Context;

  public WritableRepository(AppDbContext dbContext)
    => (Context, Collection) = (dbContext, dbContext.Set<T>());

  public virtual async Task<T> InsertAsync(T entity)
  {
    await Collection.AddAsync(entity);
    await Context.SaveChangesAsync();
    return entity;
  }

  public virtual async Task<T> UpdateAsync(int id, T entity)
  {
    entity.Id = id;
    Context.Entry(entity).CurrentValues.SetValues(entity);

    Context.Update(entity);
    await Context.SaveChangesAsync();
    return entity;
  }
}