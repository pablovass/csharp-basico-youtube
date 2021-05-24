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
        case 1:
          WriteLine("Monday");
          break;
        case 2:
          WriteLine("Tuesday");
          break;
        case 3:
          WriteLine("Wednesday");
          break;
        case 4:
          WriteLine("Thursday");
          break;
        case 5:
          WriteLine("Friday");
          break;
        case 6:
          WriteLine("Saturday");
          break;
        case 7:
          WriteLine("Sunday");
          break;
      }
    }
  }
}
