namespace Teste.Topaz.App.DTO;

sealed class GeneroDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public DateTime DataCadastro { get; set; }
    public string Nome { get; set; }

    public GeneroDTO()
    {
        ID = Guid.NewGuid();
        DataCadastro = DateTime.Now;
    }
}