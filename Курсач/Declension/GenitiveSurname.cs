using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloApp;

namespace Declension
{
    class GenitiveSur
    {
        /// <summary>
        /// Метод перетворення фамілії в родовий відмінок
        /// </summary>
        /// <param name="surnames"></param>
        /// <returns></returns>
        public static List<string> GenitiveSurname(List<string> sur, List<string> sex)
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
                else if (surnames[i].EndsWith("о") && sex[i].Equals("ж"))
                {
                    continue;
                }
                else if (sex[i].Equals("ж") && surnames[i].EndsWith("а") && (surnames[i].EndsWith("жа") || surnames[i].Contains("сь")))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "ої";
                }
                else if (surnames[i].EndsWith("а") && sex[i].Equals("ж"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "и";
                }
                else if ((surnames[i].EndsWith("ов") || surnames[i].EndsWith("ів") ||
                          surnames[i].EndsWith("ев") || surnames[i].EndsWith("єв") || surnames[i].EndsWith("їв") ||
                          surnames[i].EndsWith("ин") || surnames[i].EndsWith("ін") ||
                          surnames[i].EndsWith("їн")) && sex[i].Equals("м"))
                {

                    surnames[i] += "а";
                }
                else if (surnames[i].EndsWith("я"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "і";
                }
                else if (surnames[i].EndsWith("ень"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 3);
                    surnames[i] += "ня";
                }
                else if (surnames[i].EndsWith("ь") || surnames[i].EndsWith("й"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "я";
                }
                else if (surnames[i].EndsWith("ий"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 2);
                    surnames[i] += "ого";
                }
                else if (surnames[i].EndsWith("а"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "и";
                }
                else if (surnames[i].EndsWith("а") && sex[i].Equals("ж"))
                {
                    surnames[i] = surnames[i].Substring(0, surnames[i].Length - 1);
                    surnames[i] += "ої";
                }
                else
                {
                    if (sex[i].Equals("м"))
                    {
                        surnames[i] += "а";
                    }
                }
            }


            return surnames;
        }
    }
}
