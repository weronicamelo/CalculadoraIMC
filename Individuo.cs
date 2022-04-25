public class Individuo 
{
    public String Nome { get; set; }
    public double Altura { get; set; }
    public double Peso {  get; set; } 
    public double IMC { get => Peso / (Altura * Altura); }
    public string ClassificacaoImc
    {
        get {

            if(IMC < 18.5)
            {
                return "Abaixo do Peso."; 
            }

            else if(IMC <= 24.9)
            {
                return "Peso Normal.";
            }

            else if(IMC <= 29.9)
            {
                return "Sobrepeso.";
            }

            else if(IMC <= 34.9)
            {
                return "Obesidade Grau I.";
            }

            else if(IMC <= 39.9)
            {
                return "Obesidade Grau II.";
            }

            else
            {
                return "Obesidade Grau III ou Mórbida.";
            }

        }
    }

    public double PesoIdeal
    {
        get{

            if (IMC < 18.5)
            {
                return Math.Round((18.5 * Altura * Altura) - Peso, 2);
            } 
            else if (IMC > 24.9)
            {
                return Math.Round(Peso - (24.9 * Altura * Altura), 2);
            }
            else return 0; 
        }
    }
    
    public Individuo(string nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }   

     public Individuo()
    {
        Nome = " ";
        Altura = 0;
        Peso = 0;
    }
}