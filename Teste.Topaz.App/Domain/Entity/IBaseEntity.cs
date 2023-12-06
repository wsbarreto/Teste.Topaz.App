namespace Teste.Topaz.App.Domain.Entity;

public interface IBaseEntity
{
    Guid ID { get; }
    DateTime DataCadastro { get; }
}
