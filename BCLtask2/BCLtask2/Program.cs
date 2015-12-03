using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BCLtask2
{
    class Program
    {
        /*
        Напишите метод для сортировки массива строк в независимости 
        от региональных стандартов пользователя. Использование Linq запрещено.
        */
        static void Main(string[] args)
        {
            String[] stringsForTest = { "case",  "encyclopædia",
                            "encyclopædia", "Archæology", "Case", "encyclopaedia",
                            "encyclopedia" , "ARCHÆOLOGY" };

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.WriteLine("Current Culture: {0}",
                              CultureInfo.CurrentCulture.Name);

            List<String> list = ConvertToInvariantCulture(stringsForTest);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }

        private static List<String> ConvertToInvariantCulture(string[] arr)
        {
            List<String> list = new List<string>(arr);
            list.Sort(CustomCompare);
            return list;
        }

        // Custom compare
        public static int CustomCompare(String x, String y)
        {
            return String.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
