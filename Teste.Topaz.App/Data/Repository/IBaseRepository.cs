using Teste.Topaz.App.Entity;

namespace Teste.Topaz.App.Data.Repository;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task InsertAsync(TEntity entity);

    Task UpdateAsync(TEntity entity);

    Task DeleteAsync(TEntity entity);

    Task<IEnumerable<TEntity>> FindAllAsync();

    Task<TEntity> FindByIdAsync(Guid id);

    Task<TEntity> FindByPredicateAsync(Predicate<TEntity> predicate);
    Task SaveChangesAsync();
}
