namespace BomManager.Services;

public interface IRepository<T> {
  Task<T> AddAsync(T item);
  void Delete(T item);
  Task<T> GetByIdAsync(Guid id);
  Task<IEnumerable<T>> GetAsync();
  Task SaveAsync();
  T Update(T item);
}
