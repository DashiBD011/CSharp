using System;

namespace Hw_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftFurniture furn = new SoftFurniture(12, 12, "прага","пружина","текстиль",true);
            SoftFurniture furn1 = new SoftFurniture("sd","asd",false);
            Furniture furn2 = new Furniture(13.2,23.1,"kosmos");
            Sofa sofa = new Sofa(4);
          
            
           

            Console.WriteLine(furn2.Info());
            Console.WriteLine(furn.AllInfo());
            Console.WriteLine(furn1.Info());
            Console.WriteLine(sofa.Info());
        }
    }
}
