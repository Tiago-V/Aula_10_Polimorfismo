using System;

namespace Aula_10_Polimorfismo_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relatórios!");
            Console.WriteLine();
            Relatorio relatorio = new Relatorio();
            Mensal mensal = new Mensal();
            Anual anual = new Anual();
            relatorio.MostrarRelatorio();
            Console.WriteLine();
            mensal.MostrarRelatorio();
            Console.WriteLine();
            anual.MostrarRelatorio();
        }
    }
}
