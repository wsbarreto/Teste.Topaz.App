namespace Teste.Topaz.App.DTO;

public class CompactDiscDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public string Titulo { get; set; }
    public string Genero { get; }
    public IList<FaixaDTO> Faixas { get; set; }
    public DateTime DataCadastro { get; set; }

    public CompactDiscDTO()
    {
        ID = Guid.NewGuid();
        Faixas = new List<FaixaDTO>();
        DataCadastro = DateTime.Now;
    }

    public void AdicionarFaixas(string titulo, decimal duracao, IList<ArtistaDTO> artistas) =>
        Faixas.Add(new FaixaDTO
        {
            ID = Guid.NewGuid(),
            Titulo = titulo,
            Artistas = artistas,
            DataCadastro = DateTime.Now,
            Duracao = duracao
        });
}