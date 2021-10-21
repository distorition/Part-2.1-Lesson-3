using System;

namespace Part_2._1_Lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AddToBalans(12);
            
            bank.TakeInfo();
            bank.AddMoneTo(11, 33);
            bank.TakeInfo();

            Bank bank1 = new Bank();
            bank1.TakeInfo();
            bank1.AddToBalans(111);
            bank1.TakeInfo();
        }
    }
}
