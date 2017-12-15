using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NecessaryClasses;

namespace StorageBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Меню демонстрационная 
            //Класс HDD аналогична с двумя другими
            Storage[] storage = new Storage[2];
            storage[0] = new Flash("StorJet", 16000, 4800);
            storage[1] = new DVD("Фильмы", 9000, 50);
            Console.WriteLine(storage[1].GetReference());
            Console.WriteLine(storage[1].GetSpace());
            storage[1].CopyDataToDrive(4000);
            Console.WriteLine(storage[1].EnquiryFreeSpace());
            Console.WriteLine(storage[0].GetReference()); 
            Console.WriteLine(storage[0].GetSpace());
            Console.WriteLine("Скопировано 500");
            storage[0].CopyDataToDrive(500);
            Console.WriteLine(storage[0].EnquiryFreeSpace());
            Console.WriteLine("Скопировано 2015");
            storage[0].CopyDataToDrive(2015);
            Console.WriteLine(storage[0].EnquiryFreeSpace());
            Console.WriteLine(storage[0].GetSpace());
            //storage[0].EnquiryFreeSpace();
            Console.ReadLine();
        }
    }
}
