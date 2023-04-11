using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.classes
{
    public static class Utils
    {
     public static void BarraCarregamento ()   

    {
     Console.BackgroundColor = ConsoleColor.Red;
     Console.Write("Fechando");

      for (var i = 0; i < 10; i++)
    {
    Console.Write("_");
    Thread.Sleep(300);
    Console.ResetColor();
   
    }
    Console.Write("!");
    Thread.Sleep(300);
    Console.ResetColor();

}
}
}

