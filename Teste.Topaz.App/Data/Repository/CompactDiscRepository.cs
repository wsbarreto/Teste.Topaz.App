using Teste.Topaz.App.Data.Context;
using Teste.Topaz.App.Domain.Entity;
using Teste.Topaz.App.Domain.Interface.Repository;

namespace Teste.Topaz.App.Data.Repository;

public class CompactDiscRepository : BaseRepository<CompactDiscEntity>, ICompactDiscRepository
{
    private readonly DataContext _dataContext;
    public CompactDiscRepository(DataContext dataContext) : base(dataContext) =>
        this._dataContext = dataContext;
}