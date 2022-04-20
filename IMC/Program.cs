// Daniel Arturo Amarillo Jorge 1032937350 
// Grupo 213023_120
// Programación
// Problema: IMC
// Código fuente: Autoría propia
// Metodos: IMCP

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMCP IMC = new IMCP();
            double x;
            Console.WriteLine("Este programa medira tu IMC, y te dira si: Tienes un peso inferior, normal, superior u obesidad");
            Console.WriteLine("Ingresa tu estatura en metros \n Ejemplo 1.77");
            string n1 = Convert.ToString(Console.ReadLine());
            n1 = n1.Replace(".", ",");
            x = Double.Parse(n1);
            Console.WriteLine("Ingresa tu peso en Kilogramos \n Ejemplo 77");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu IMC es: " + IMC.IMC(x, n2));
            Console.WriteLine("Lo lcual signica que es: " + IMC.imc);
            Console.WriteLine("Da cualquier tecla para terminar...");
            Console.ReadKey();
        }

    }

    public class IMCP
    {
        private double estatura;
        private double peso;
        private double imcf;
        private double x;
        public string imc;
        public double IMC(double n1, int n2)
        {
            this.estatura = n1;
            this.peso = n2;
            estatura = Math.Pow(estatura, 2);
            imcf = peso / estatura;
            x = imcf;
            if (x < 18.5)
            {
                imc = "Peso Inferior al normal";
            }
            else if (x >= 18.5 && x <= 24.9)
            {
                imc = "Peso normal";
            }
            else if (x >= 25 && x <= 29.9)
            {
                imc = "Peso superiior al normal";
            }
            else if (x >= 30)
            {
                imc = "Obesidad";
            }

            return x;
        }
    }
}