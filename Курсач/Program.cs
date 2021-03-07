using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace HelloApp // объявление нового пространства имен
{
    class Program   // объявление нового класса
    {
        static void Main(string[] args) // объявление нового метода
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            for (; ; )
            {
                Console.Write("Введіть назву файлу який містить перелік ФІО людей: ");
                string fileName = Console.ReadLine();

                List<string> listOfSurname = new List<string>();
                List<string> listOfNames = new List<string>();
                List<string> listOfMiddleName = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader(fileName,Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] lineFio = line.Split(" ");
                            listOfSurname.Add(lineFio[0]);
                            listOfNames.Add(lineFio[1]);
                            listOfMiddleName.Add(lineFio[2]);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Такого файлу не існує");
                }

                List<string> Everything = new List<string>();
                for (int i = 0; i < listOfNames.Count; i++)
                {
                    string fio = listOfSurname[i] + " " + listOfNames[i] + " " + listOfMiddleName[i];
                    Everything.Add(fio);
                }

                


                Console.ReadKey();
            }
        }

        public static List<string> GenitiveSurname(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

    } 
} 


