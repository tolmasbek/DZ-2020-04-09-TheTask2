namespace DZ09042020
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
        public override void EditDocument()
        {
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}