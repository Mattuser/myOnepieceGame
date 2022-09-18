using mygame.Domain.Arenas;
using mygame.Domain.Personagens;
namespace mygame.Domain.Batalhas;

public class Batalha
{
    bool BattleIsRunning { get; set; } = false;
    Arena? Arena { get; set; }
    Personagem? Personagem1 { get; set; }
    Personagem? Personagem2 { get; set; }

    public string Start()
    {
        if (!BattleIsRunning)
            BattleIsRunning = true;
        return "A batalha iniciou";
    }

    public string End()
    {
        if (BattleIsRunning)
            BattleIsRunning = false;
        return "A batalha acabou";
    }

    public string Result()
    {
        string vencedor = "";
        Start();

        if (BattleIsRunning)
        {
            if (Personagem1!.AtributosFisicos!.Forca > Personagem2!.AtributosFisicos!.Forca)
            {
                vencedor = Personagem1.Apelido!;

            }
            else {
                vencedor = Personagem2.Apelido!;
            }
        }

        End();
        return $"o vencedor da batalha foi {vencedor}";



    }

    public Batalha(Personagem personagem1, Personagem personagem2)
    {
        Personagem1 = personagem1;
        Personagem2 = personagem2;
    }

    public Batalha()
    {

    }

}