using System;
using System.IO;

namespace Pencil
{
    class Program
    {
       
        static void Main()
        {         
            //Pencil pencil = new Pencil(170,"wood",Condition.broken,Colour.Black,false,3.5);
            //pencil.Info();

            Pencil[] nabor =
            {
                new Pencil(170,"wood",Condition.sharpened,Colour.Red,false,5),
                new Pencil(170,"wood",Condition.sharpened,Colour.Blue,false,5),
                new Pencil(170,"wood",Condition.blunt,Colour.Gray,true,3.5),
                new Pencil(170,"wood",Condition.broken,Colour.Yellow,false,0),
                new Pencil(170,"wood",Condition.broken,Colour.Green,false,0)
            };

            foreach (var pencil in nabor)
            {
                pencil.Info();
                Console.WriteLine();
            }
        }
       
    }
}
