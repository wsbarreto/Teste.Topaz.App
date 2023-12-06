namespace Teste.Topaz.App.DTO;

public class FaixaDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public DateTime DataCadastro { get; set; }
    public string Titulo { get; set; }
    public decimal Duracao { get; set; }
    public IList<ArtistaDTO> Artistas { get; set; }

    public FaixaDTO()
    {
        this.ID = Guid.NewGuid();
        this.DataCadastro = DateTime.Now;
        this.Artistas = new List<ArtistaDTO>();
    }
}