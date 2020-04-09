using DZ_DocumentWorkerSpace;

namespace DZ_ProDocumentWorkerSpace
{
    // Производный класс наследованный от базового класса DocumentWorker
    public class ProDocumentWorker : DocumentWorker
    {
        // Предопределение виртуального метода из базового класса
        public override void OpenDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
            
            //base.OpenDocument(); // Доступ к виртуальным членам базового класса из этого производного класса
        }
        // Предопределение виртуального метода из базового класса
        public override void EditDocument()
        {
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
            
            //base.EditDocument(); // Доступ к виртуальным членам базового класса из производного класса
        }
    }
}