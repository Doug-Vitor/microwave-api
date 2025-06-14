public interface IReadonlyRepository<T> where T : BaseEntity
{
  Task<T> GetByIdAsync(int id);
  Task<IEnumerable<T>> GetAllAsync();
}