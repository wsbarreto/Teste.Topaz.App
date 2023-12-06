namespace Teste.Topaz.App.Entity;

sealed class CompactDiscEntity : IBaseEntity
{
    public Guid ID { get; }
    public string Titulo { get; }
    public string Genero { get; }
    public IList<FaixaEntity> Faixas { get; }
    public DateTime DataCadastro { get; }

    public CompactDiscEntity(Guid id, string titulo, string genero, IList<FaixaEntity> faixas, DateTime dataCadastro)
    {
        this.ID = id;
        this.Titulo = titulo;
        this.Genero = genero;
        this.Faixas = faixas;
        this.DataCadastro = dataCadastro;
    }
}