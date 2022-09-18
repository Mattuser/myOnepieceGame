namespace mygame.Domain.Personagens;

    public class AtributosFisicos
    {
      
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Forca { get; set; }
        public int Velocidade { get; set; }

        public AtributosFisicos(double altura, double peso, double forca, int velocidade)
        {
            Altura = altura;
            Peso = peso;
            Forca = forca;
            Velocidade = velocidade;
        }

        public AtributosFisicos()
        {
        }
    }
