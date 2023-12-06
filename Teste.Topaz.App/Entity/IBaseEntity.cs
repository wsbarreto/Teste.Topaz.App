namespace Teste.Topaz.App.Entity;

public interface IBaseEntity
{
    Guid ID { get; }
    DateTime DataCadastro { get; }
}
