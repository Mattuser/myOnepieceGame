namespace mygame.Domain.Personagens;

public interface IPersonagem
{
    public string? Name { get; set; }
    public string? Apelido { get; set; }
    public int? Idade { get; set; }
   
}
