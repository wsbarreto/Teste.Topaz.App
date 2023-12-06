namespace Teste.Topaz.App.DTO;

sealed class ArtistaDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public DateTime DataCadastro { get; set; }
    public string Nome { get; set; }

    public ArtistaDTO()
    {
        this.ID = Guid.NewGuid();
        this.DataCadastro = DateTime.Now;
    }
}