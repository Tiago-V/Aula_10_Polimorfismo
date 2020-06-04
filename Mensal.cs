namespace Aula_10_Polimorfismo_Exercicio
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            
            base.MostrarRelatorio();
            
            System.Console.WriteLine("Mostrar relatório por mês.");

        }
    }
}