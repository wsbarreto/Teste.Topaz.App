using Teste.Topaz.App.Domain.Entity;
using Teste.Topaz.App.Domain.Interface.Repository;
using Teste.Topaz.App.Domain.Interface.Service;

namespace Teste.Topaz.App.Service;

public class CompactDiscService : BaseService<CompactDiscEntity>, ICompactDiscService
{
    private readonly ICompactDiscRepository _repository;
    public CompactDiscService(ICompactDiscRepository repository) : base(repository) =>
        this._repository = repository;
}