using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 3- No projeto MatematicaBasica crie um 
               Programa que calcule a soma de dois números inteiros.
               Considere que o usuário vai digitar esses dois números.
             */
            int num1;
            int num2;
            int soma;
            //entrada de dados
            Console.WriteLine("jovem jovem, digite o primeiro numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jovem jovem, digite o segundo numero ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma desses numeros é: "+ soma);
            Console.ReadLine();

        }
    }
}
