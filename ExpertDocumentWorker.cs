namespace DZ09042020
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в новом формате");
        }   
    }
}