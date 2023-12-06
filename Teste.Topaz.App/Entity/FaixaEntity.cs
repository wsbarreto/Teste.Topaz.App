namespace Teste.Topaz.App.Entity;

public class FaixaEntity : IBaseEntity
{
    public Guid ID { get; }
    public DateTime DataCadastro { get; }
    public string Titulo { get; }
    public decimal Duracao { get; }
    public IList<ArtistaEntity> Artistas { get; }

    public FaixaEntity(Guid id, DateTime dataCadastro, string titulo, decimal duracao, IList<ArtistaEntity> artistas)
    {
        this.ID = id;
        this.DataCadastro = dataCadastro;
        this.Titulo = titulo;
        this.Duracao = duracao;
        this.Artistas = artistas;
    }
}