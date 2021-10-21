using System;

namespace Part_2._1_Lesson_3._2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("напишите слово");
            string words = Console.ReadLine();
            ClassForRevers classFor = new ClassForRevers();
            classFor.Revers(words);
            

        }
    }
}
