namespace Teste.Topaz.App.Domain.Interface.Service;

public interface IBaseService<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync<TValidator>(TEntity obj);
    Task<TEntity> UpdateAsync<TValidator>(TEntity obj);
    Task DeleteAsync(TEntity entity);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByPredicateAsync(Predicate<TEntity> predicate);
    Task<TEntity> GetByIdAsync(Guid id);
}