using mygame.Domain.Batalhas;
using mygame.Domain.enums;
using mygame.Domain.Personagens;

Personagem mihawk = new()
{
    Name = "Mihawk",
    Apelido = "Olhos de Falcão",
    Idade = 39,
    AtributosFisicos = new AtributosFisicos()
    {
        Altura = 1.80,
        Forca = 200.0,
        Peso = 83.0,
        Velocidade = 200
    },
    Maestria = Maestria.Espada,
};
Personagem shanks = new()
{
    Name = "Shanks",
    Apelido = "Ruivo",
    Idade = 39,
    AtributosFisicos = new AtributosFisicos()
    {
        Altura = 1.790,
        Forca = 250.0,
        Peso = 83.0,
        Velocidade = 260
    },
    Maestria = Maestria.Lutador,
};

Batalha batalha1 = new Batalha(mihawk, shanks);

Console.WriteLine(batalha1.Start());
Console.WriteLine(batalha1.Result());
Console.WriteLine(batalha1.End());