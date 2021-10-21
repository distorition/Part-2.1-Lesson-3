using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_3._1
{
   public class User
    {
     
        public User()
        {
            
            Banks = new BanksCount();
        }
        public BanksCount Banks { get; set; }
    }
}
