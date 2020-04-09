using System;
using DZ_DocumentWorkerSpace;       /////
using DZ_ProDocumentWorkerSpace;    //// Пространство имен
using DZ_ExpertDocumentWorkerSpace; ///

namespace DZ_2020_04_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                • Задание 2
                    A. Создайте проект по шаблону Console Application.
                    1. Требуется:
                        • Создайте класс DocumentWorker.
                        • В теле класса создайте три метода OpenDocument(), EditDocument(),
                        SaveDocument().
                        • В тело каждого из методов добавьте вывод на экран соответствующих
                        строк: "Документ открыт", "Редактирование документа доступно в
                        версии Про", "Сохранение документа доступно в версии Про".
                        • Создайте производный класс ProDocumentWorker.
                        • Переопределите соответствующие методы, при переопределении
                        методов выводите следующие строки: "Документ отредактирован",
                        "Документ сохранен в старом формате, сохранение в остальных
                        форматах доступно в версии Эксперт".
                        • Создайте производный класс ExpertDocumentWorker от базового
                        класса ProDocumentWorker.
                        • Переопределите соответствующий метод. При вызове данного метода
                        необходимо выводить на экран "Документ сохранен в новом
                        формате".
                        • В теле метода Main() реализуйте возможность приема от пользователя
                        номера ключа доступа pro и exp.
                        • Если пользователь не вводит ключ, он может пользоваться только
                        бесплатной версией (создается экземпляр базового класса), если
                        пользователь ввел номера ключа доступа pro и exp, то должен
                        • создаться экземпляр соответствующей версии класса, приведенный к
                        базовому - DocumentWorker.
            */

                System.Console.Write("/// DocumentWorker ///\n1 pro версия\n2 exp версия\n3 free версия\nВыберите одно из версий: ");
            int choise = int.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1: 
                {   
                    string keyPro = "20200409";
                        Console.Write("Введите ключ Pro версии: ");
                    string pro = Console.ReadLine();
                    if(pro == keyPro)
                    {
                        ProDocumentWorker docwPro = new ProDocumentWorker(); 
                            System.Console.WriteLine();
                            System.Console.WriteLine("Вы в версии Pro");
                        docwPro.OpenDocument();
                        docwPro.EditDocument();
                    }
                    else
                    {
                        DocumentWorker docwFree = new DocumentWorker();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Вы в версии Free");
                        docwFree.OpenDocument();
                        docwFree.EditDocument();
                        docwFree.SaveDocument();
                    }
                    break;
                }
                case 2: 
                {
                    string keyExp = "20200410";
                        Console.Write("Введите ключ Exp версии: ");
                    string pro = Console.ReadLine();
                    if(pro == keyExp)
                    {
                        ExpertDocumentWorker docwPro = new ExpertDocumentWorker();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Вы в версии Exp"); 
                        docwPro.SaveDocument();
                    }
                    else
                    {
                        DocumentWorker docwFree = new DocumentWorker();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Вы в версии Free");    
                        docwFree.OpenDocument();
                        docwFree.EditDocument();
                        docwFree.SaveDocument();
                    }
                    break;
                }
                default:
                {
                        DocumentWorker docwFree = new DocumentWorker();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Вы в версии Free");
                        docwFree.OpenDocument();
                        docwFree.EditDocument();
                        docwFree.SaveDocument();
                    break;
                }   
            }
            Console.ReadKey();
        }
    }
}