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
    static void Main(string[] args)
    {
      string[] testStrings = new string[3];

      double value = 1634.92;
      Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
      Console.WriteLine("Current Culture: {0}",
                        CultureInfo.CurrentCulture.Name);

      testStrings[0] = value.ToString();


      Thread.CurrentThread.CurrentCulture = new CultureInfo("fr");
      Console.WriteLine("Current Culture: {0}",
                        CultureInfo.CurrentCulture.Name);

      testStrings[1] = value.ToString();

      ConvertToInvariantCulture(testStrings);

      for (int i = 0; i < testStrings.Length; i++)
      {
        Console.WriteLine(testStrings[i]);
      }

      Console.ReadKey();
    }

    private static void ConvertToInvariantCulture(string[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = arr[i].ToString(CultureInfo.InvariantCulture);
      }
    }

  }
}
