using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCLtask3
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] stringTests = new string[5];

      for (int i = 0; i < stringTests.Length; i++)
      {
        stringTests[i] = i+1.ToString();
      }

      Console.WriteLine(ConcatEverySecond(stringTests));

      Console.ReadKey();
    }

    //испльзую StringBuilder т.к. он не создает в куче новых объектов при изменении содержимого строки (расширяется до определенного capacity, в дальнейшем эта capacity, при необходимости, увеличивается)

    private static string ConcatEverySecond(string[] arr)
    {
      StringBuilder result = new StringBuilder();

      for (int i = 0; i < arr.Length; i++)
      {
        if(i % 2 == 0)
          result.Append(arr[i]);
      }

      return result.ToString();
    }

  }
}
