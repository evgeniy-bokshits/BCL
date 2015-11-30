using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCLtask1
{
  class Program
  {
    static void Main(string[] args)
    {
      GetAttribute(typeof(Rectangle));

      Console.ReadKey();
    }

    private static void GetAttribute(Type t)
    {
      object[] attrs = t.GetCustomAttributes(false);
      foreach (RoleInfoAttribute roleAttr in attrs)
      {
        Console.WriteLine(roleAttr.Name + " " + roleAttr.Email);
      }
    }
  }

  [AttributeUsage(AttributeTargets.Class)]
  public class RoleInfoAttribute : System.Attribute
  {
    public string Name { get; set; }
    public string Email { get; set; }

    public RoleInfoAttribute()
    { }

    public RoleInfoAttribute(string name)
    {
      Name = name;
    }

    public RoleInfoAttribute(string name, string email)
    {
      Name = name;
      Email = email;
    }

  }

  [RoleInfo("Yauheni", "yauheni_bokshyts@epam.com")]
  public class Rectangle
  {
    public int SideA { get; set; }
    public int SideB { get; set; }
    public Rectangle(int a, int b)
    {
      SideA = a;
      SideB = b;
    }
    public int Square(int a, int b)
    {
      return a * b;
    }
  }

}
