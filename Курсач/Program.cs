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
            // Підключення української мови
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

        /// <summary>
        /// Метод перетворення фамілії в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveSurname(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

        /// <summary>
        /// Метод перетворення імені в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveName(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

        /// <summary>
        /// Метод перетворення по батькові в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveMiddleName(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

        /// <summary>
        /// Метод перетворення фамілії в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeSurname(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

        /// <summary>
        /// Метод перетворення імені в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeName(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }

        /// <summary>
        /// Метод перетворення імені в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeMIddleName(List<string> surnames)
        {
            List<string> genSur = new List<string>();

            for (int i = 0; i < surnames.Count; i++)
            {

            }


            return new List<string>();
        }
    } 
} 


