namespace DZ_DocumentWorkerSpace
{
    // Базовый класс
    public class DocumentWorker
    {
        // виртуальные методы в базовом классе
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");
        }
        // виртуальные методы в базовом классе
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        // виртуальные методы в базовом классе
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}