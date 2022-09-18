
using mygame.Domain.enums;

namespace mygame.Domain.Personagens;

public class Personagem : IPersonagem
{

    public string? Name { get; set; }
    public string? Apelido { get; set; }
    public int? Idade { get; set; }

    public AtributosFisicos? AtributosFisicos { get; set; }
    public Habilidade? Habilidades { get; set; }
    public Maestria? Maestria { get; set; }

    public Personagem(string name, string apelido, int idade, AtributosFisicos atributosFisicos, Habilidade habilidades, Maestria maestria)
    {
        Name = name;
        Apelido = apelido;
        Idade = idade;
        AtributosFisicos = atributosFisicos;
        Habilidades = habilidades;
        Maestria = maestria;
    }

    public Personagem (string name)
    {
        Name = name;
    }
    public Personagem() { }


}
