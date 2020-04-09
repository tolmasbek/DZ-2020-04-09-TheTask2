using DZ_ProDocumentWorkerSpace;

namespace DZ_ExpertDocumentWorkerSpace
{
    // Производный класс наследованный от базового класса ProDocumentWorker
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        // Предопределение виртуального метода из базового класса
        public override void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в новом формате");

            //base.SaveDocument(); // Доступ к виртуальным членам базового класса из производного класса
        }   
    }
}