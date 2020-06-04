using System;

namespace Aula_10_Polimorfismo_Exercicio
{
    public class Relatorio
    {
        public DateTime data { get; set; }
        public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrar relatório.");
        }
    }
}