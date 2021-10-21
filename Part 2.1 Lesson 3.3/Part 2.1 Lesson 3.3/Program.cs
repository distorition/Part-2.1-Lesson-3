using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Part_2._1_Lesson_3._3
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string FilePath = @"D:\visual Project\КУРСЫ GEKK BRAINS\Part 2.1 Lesson 3.3\NewFile.txt";
            string fileForMail = "Mail.txt";
            List<string> list = new List<string>();
            using(StreamReader stream=new StreamReader(FilePath))
            {
                while(!stream.EndOfStream)
                {
                    list.Add(stream.ReadLine());
                }
            }
            string[] name = list[0].Split(' ');
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Contains("@"))
                {
                    File.AppendAllText(fileForMail, name[i]);
                    File.AppendAllText(fileForMail, Environment.NewLine);
                }
            }
          
           
        }

        public void Serachmail(ref string s)
        {
            string FilePath = @"D:\visual Project\КУРСЫ GEKK BRAINS\Part 2.1 Lesson 3.3\NewFile.txt";
          
            List<string> list = new List<string>();
            using (StreamReader stream = new StreamReader(FilePath))
            {
                while (!stream.EndOfStream)
                {
                    list.Add(stream.ReadLine());
                }
            }
            string[] name = list[0].Split(' ');
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Contains(s))
                {
                    Console.WriteLine($"{"#"}{name[i]}{"#"}");
                }
            }
        }


    }
}
