namespace Teste.Topaz.App.Domain.Entity;

public class FaixaEntity : IBaseEntity
{
    public Guid ID { get; }
    public DateTime DataCadastro { get; }
    public string Titulo { get; }
    public decimal Duracao { get; }

    public FaixaEntity(Guid id, DateTime dataCadastro, string titulo, decimal duracao)
    {
        ID = id;
        DataCadastro = dataCadastro;
        Titulo = titulo;
        Duracao = duracao;
    }
}