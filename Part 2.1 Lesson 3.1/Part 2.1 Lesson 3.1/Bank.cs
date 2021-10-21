using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_3._1
{
    class Bank
    {
        public Bank()
        {
            user = new User();
        }
         public User user { get; set; }
        private void TakeCount()
        {

            if (Rand() == user.Banks.NumCount)
            {
                Rand();
            }

        }
      public void AddMoneTo(int numCount,int sumToAdd)
        {
            
                if (user.Banks.NumCount == numCount)
                {

                    user.Banks.Balans += sumToAdd;
                }
                else
                {
                    Console.WriteLine("такого счёта не существует ");
                }
          
           
        }
    
        
        public void AddToBalans(int value)
        {
            user.Banks.Balans += value;
        }
        public void TakeMoney(int value)
        {
            if (user.Banks.Balans > value)
            {
                user.Banks.Balans -= value;
            }
            else
            {
                Console.WriteLine("на балансе недостаточно средств");
            }
        }
        private int Rand()
        {
            Random random = new Random();
            int coout = random.Next(11,13);
            user.Banks.NumCount = coout;
            return coout;
        }
        public void TakeInfo()
        {
            //Random random = new Random();
            Rand();
            TakeCount();
            Console.WriteLine($"ваш номер счёта №{user.Banks.NumCount}, ваш баланс{user.Banks.Balans} ");
            //TypeCount count = (TypeCount)random.Next(1, 4);
            //Console.WriteLine($" ваш тип счёта {count}");
        }
}  }

