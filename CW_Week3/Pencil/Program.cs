using System;
using System.IO;

namespace Pencil
{
    class Program
    {
       
        static void Main()
        {         
            Pencil pencil = new Pencil(170,"wood",Condition.broken,Colour.Black,false,3.5);
            pencil.Info();
           

        }
       
    }
}
