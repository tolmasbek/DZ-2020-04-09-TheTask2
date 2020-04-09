namespace DZ09042020
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}