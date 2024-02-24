using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace выход
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitWord = "exit";

            Console.WriteLine("для начала работы цикла нажмите ENTER");
            string userInput = Console.ReadLine();

            while (exitWord != userInput)
            {
                Console.WriteLine("для выхода введите " + exitWord);
                string exitUserInput = Console.ReadLine();

                if (exitUserInput == exitWord)
                {
                    exitWord = userInput;
                    Console.WriteLine("вы вышли из цикла");
                }

            }
        }
    }
}
