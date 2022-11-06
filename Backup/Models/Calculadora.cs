using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploC.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            Double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180; // Pegando o radiano
            double seno = Math.Sin(radiano); //Radiano pegando o Metodo da class Math
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno,4)}"); // Calculo do radiano X o Seno e Com s Math Round A redandando para 4 digitos
        }
         public void Cos(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cos = Math.Sin(radiano);
            Console.WriteLine($"Cos de {angulo}° = {Math.Round(cos,4)}");
        }
         public void Tangene(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tg = Math.Sin(radiano);
            Console.WriteLine($"Tg de {angulo}° = {Math.Round(tg,4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($" Raiz Quadrada de {x} = {raiz}");
        }

    }
}
