public interface IWritableRepository<T> where T : BaseEntity
{
  Task<T> InsertAsync(T entity);
  Task<T> UpdateAsync(int id, T entity);
}