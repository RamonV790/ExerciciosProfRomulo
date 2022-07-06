using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nt1;
            double nt2;
            double nt3;
            double soma;
            double media;
            string nome, resultado;
            double nfinal;
            double mfinal;
            Console.WriteLine("Nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nota do primeiro bimestre: ");
            nt1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do segundo bimestre: ");
            nt2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do terceiro bimestre: ");
            nt3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Aluno: {nome}");
            soma = nt1 + nt2 + nt3;
            nfinal = Math.Round(soma, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Soma das notas: {nfinal}");
           media = soma / 3;
            mfinal = Math.Round(media, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Média das notas: {mfinal}");
            if (media >=7){
                resultado = "aprovado";
            }
            else
            {
                resultado = "reprovado";
            }
           Console.WriteLine($"O aluno {nome} foi {resultado}");
            Console.ReadLine();
        }
    }
}
