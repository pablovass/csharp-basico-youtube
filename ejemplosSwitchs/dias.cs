using System;
using static System.Console;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day)
      {
        case 6:
          WriteLine("Today is Saturday.");
          break;
        case 7:
          WriteLine("Today is Sunday.");
          break;
          
        default:
          WriteLine("Looking forward to the Weekend.");
          break;
      }
    }
  }
}
