namespace Teste.Topaz.App.Domain.Entity;

public class CompactDiscEntity
{
    public Guid TB_FAIXA_ID { get; }
    public Guid TB_GENERO_ID { get; }
    public string Titulo { get; }
    //public IList<FaixaEntity> Faixas { get; }
    public DateTime DataCadastro { get; }

    public CompactDiscEntity(Guid tb_faixa_id, Guid tb_genero_id, string titulo)
    {
        TB_FAIXA_ID = tb_faixa_id;
        TB_GENERO_ID = tb_genero_id;
        Titulo = titulo;
    }
}