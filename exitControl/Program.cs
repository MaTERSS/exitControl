/*Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit. 
Помните, цикл работает, пока выполняется условие. А противоположное отвечает за выход.
Это надо, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.*/

using System;
using System.Text;

namespace CSharplight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execution = true;
            string stopWord = "exit";

            while (execution)
            {
                Console.WriteLine("Введите сообщение:");
                string message = Console.ReadLine();

                if (message == stopWord)
                {
                    execution = false;
                }
            }
        }
    }
}