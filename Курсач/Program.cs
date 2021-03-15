using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;


namespace HelloApp // объявление нового пространства имен
{
    class Program   // объявление нового класса
    {
        static List<string> sex;
        static void Main(string[] args) // объявление нового метода
        {
            // Підключення української мови
            Console.OutputEncoding = System.Text.Encoding.Default;
            for (; ; )
            {
                sex = new List<string>();
                Console.Write("\n\nВведіть назву файлу який містить перелік ФІО людей: ");
                string fileName = Console.ReadLine();

                List<string> listOfSurname = new List<string>();
                List<string> listOfNames = new List<string>();
                List<string> listOfMiddleName = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
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

                /*
                List<string> Everything = new List<string>();
                for (int i = 0; i < listOfNames.Count; i++)
                {
                    string fio = listOfSurname[i] + " " + listOfNames[i] + " " + listOfMiddleName[i];
                    Everything.Add(fio);
                }
                */

                List<string> datMIddleName = DativeMiddleName(listOfMiddleName);
                
                List<string> genMiddleName = GenitiveMiddleName(listOfMiddleName);
                List<string> genSurname = GenitiveSurname(listOfSurname);
                List<string> datSurname = DativeSurname(listOfSurname);

                for (int i = 0; i < datSurname.Count; i++)
                {
                    Console.WriteLine($"\n{datSurname[i]} {datMIddleName[i]}");
                    Console.WriteLine($"{genSurname[i]} {genMiddleName[i]}\n");
                }


                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод перетворення фамілії в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveSurname(List<string> sur)
        {
            List<string> surnames = new List<string>();
            foreach (string elem in sur)
            {
                surnames.Add(elem);
            }

            for (int i = 0; i < surnames.Count; i++)
            {
                if (surnames[i].EndsWith("о") && sex[i].Equals("м"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "а";
                }
                else if ((surnames[i].EndsWith("ов") || surnames[i].EndsWith("ів") ||
                         surnames[i].EndsWith("ев") || surnames[i].EndsWith("єв") || surnames[i].EndsWith("їв") ||
                         surnames[i].EndsWith("ин") || surnames[i].EndsWith("ін") ||
                         surnames[i].EndsWith("їн")) && sex[i].Equals("м"))
                {

                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "а";
                }
                else if (surnames[i].EndsWith("ий"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 2);
                    surnames[i] += "ого";
                }
                else if (surnames[i].EndsWith("а") && sex[i].Equals("ж"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "ої";
                }
            }


            return surnames;
        }

        /// <summary>
        /// Метод перетворення імені в родовий відмінок
        /// </summary>
        /// 
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveName(List<string> name)
        {
            List<string> names = name;
            foreach (string elem in name)
            {
                names.Add(elem);
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (sex[i].Equals("м"))
                {

                    if (names[i].EndsWith("р"))
                    {
                        if (names[i].Substring(0, names[i].Length - 1).EndsWith("і"))
                        {
                            string temp = names[i].Substring(names[i].Length - 1, names[i].Length);
                            names[i] = names[i].Substring(0, names[i].Length - 1);
                            names[i] += ("о" + temp);
                        }
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        if (names[i].Equals("Ігор"))
                        {
                            names[i] += "я";
                        }
                        else
                        {
                            names[i] += "а";
                        }

                    } else if (names[i].EndsWith("я"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "і";
                    }
                    else if (names[i].EndsWith("й") || names[i].EndsWith("ь"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "я";
                    }
                    else if (names[i].EndsWith("о"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "а";
                    }
                    else
                    {
                        if (names[i].Substring(0, names[i].Length - 1).EndsWith("і"))
                        {
                            string temp = names[i].Substring(names[i].Length - 1, names[i].Length);
                            names[i] = names[i].Substring(0, names[i].Length - 1);
                            names[i] += ("о" + temp);
                        }
                        names[i] += "а";
                    }

                }
                else if (sex[i].Equals("ж"))
                {

                    if (names[i].EndsWith("ля"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "і";

                    }
                    else if (names[i].EndsWith("я"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);

                        names[i] += "ї";
                    }
                    else if (names[i].EndsWith("а"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "и";
                    }
                    else
                    {
                        names[i] += "і";
                    }


                }
            }


            return names;
        }

        /// <summary>
        /// Метод перетворення по батькові в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveMiddleName(List<string> mid)
        {
            List<string> middleName = new List<string>();
            foreach (string elem in mid)
            {
                middleName.Add(elem);
            }

            for (int i = 0; i < middleName.Count; i++)
            {
                if (middleName[i].EndsWith("ч"))
                {
                    middleName[i] += "а";
                }
                else
                {
                    middleName[i] = middleName[i].Substring(0, middleName[i].Length - 1);
                    middleName[i] += "и";

                }

            }

            return middleName;
        }

        /// <summary>
        /// Метод перетворення фамілії в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeSurname(List<string> sur)
        {
            List<string> surnames = new List<string>();
            foreach (string elem in sur)
            {
                surnames.Add(elem);
            }

            for (int i = 0; i < surnames.Count; i++)
            {
                if ((surnames[i].EndsWith("о") || surnames[i].EndsWith("ов") || surnames[i].EndsWith("ів") || surnames[i].EndsWith("ев") || surnames[i].EndsWith("єв") || surnames[i].EndsWith("їв") || surnames[i].EndsWith("ин") || surnames[i].EndsWith("ін") || surnames[i].EndsWith("їн")) && sex[i].Equals("м"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "у";
                }
                else if (surnames[i].EndsWith("ий"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 2);
                    surnames[i] += "ому";
                }
                else if (surnames[i].EndsWith("а") && sex[i].Equals("ж"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "ій";
                }
            }


            return surnames;
        }

        /// <summary>
        /// Метод перетворення по батькові в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeMiddleName(List<string> mid)
        {
            List<string> middleName = new List<string>();

            foreach (string elem in mid)
            {
                middleName.Add(elem);
            }

            for (int i = 0; i < middleName.Count; i++)
            {
                if (middleName[i].EndsWith("ч"))
                {
                    sex.Add("м");
                    middleName[i] += "у";
                }
                else
                {
                    sex.Add("ж");
                    middleName[i] = middleName[i].Substring(0, middleName[i].Length - 1);
                    middleName[i] += "і";
                }
            }

            return middleName;
        }

        /// <summary>
        /// Метод перетворення імені в давальний відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> DativeName(List<string> name)
        {
            List<string> names = name;
            foreach (string elem in name)
            {
                names.Add(elem);
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (sex[i].Equals("м"))
                {
                    if (names[i].EndsWith("я"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "і";
                    }
                    else if (names[i].EndsWith("й") || names[i].EndsWith("ь"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "ю";
                    }
                    else if(names[i].EndsWith("о"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "у";
                    }
                    else
                    {
                        if (names[i].Substring(0, names[i].Length - 1).EndsWith("і"))
                        {
                            string temp = names[i].Substring(names[i].Length - 1, names[i].Length);
                            names[i] = names[i].Substring(0, names[i].Length - 1);
                            names[i] += ("о"+temp);
                        }
                        names[i] += "а";
                    }



                }
                else if(sex[i].Equals("ж"))
                {
                    if (names[i].EndsWith("ха"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 2);
                        names[i] += "сі";
                    }
                    else if (names[i].EndsWith("ка"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 2);
                        names[i] += "ці";
                    }
                    else if (names[i].EndsWith("га"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 2);
                        names[i] += "";
                    }
                    else if (names[i].EndsWith("ля"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "і";
                    }
                    else if (names[i].EndsWith("я"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        
                        names[i] += "ї";
                    }
                    else if(names[i].EndsWith("а"))
                    {
                        names[i] = names[i].Substring(0, names[i].Length - 1);
                        names[i] += "і";
                    }
                    else
                    {
                        names[i] += "і";
                    }
                }
            }


            return names;
        }
    }
}


