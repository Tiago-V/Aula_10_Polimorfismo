namespace Aula_10_Polimorfismo_Exercicio
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            
            base.MostrarRelatorio();
            
            System.Console.WriteLine("Mostrar relatório por ano.");

        }
    }
}