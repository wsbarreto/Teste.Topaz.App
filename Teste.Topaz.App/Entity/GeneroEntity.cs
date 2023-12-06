namespace Teste.Topaz.App.Entity;

public class GeneroEntity : IBaseEntity
{
    public Guid ID { get; }
    public DateTime DataCadastro { get; }
    public string Nome { get; }

    public GeneroEntity(Guid id, DateTime dataCadastro, string nome)
    {
        ID = id;
        this.DataCadastro = dataCadastro;
        this.Nome = nome;
    }
}