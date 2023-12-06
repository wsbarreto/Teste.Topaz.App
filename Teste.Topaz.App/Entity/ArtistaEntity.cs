namespace Teste.Topaz.App.Entity;

public class ArtistaEntity : IBaseEntity
{
    public Guid ID { get; }
    public DateTime DataCadastro { get; }
    public string Nome { get; }

    public ArtistaEntity(Guid id, string nome, DateTime dataCadastro)
    {
        this.ID = id;
        this.Nome = nome;
        this.DataCadastro = dataCadastro;
    }
}