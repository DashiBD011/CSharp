using System;

namespace Hw_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofa sofa = new Sofa(3,"пружина","текстиль",true);        
            Console.WriteLine(sofa.Info());
            Console.WriteLine();
            Console.WriteLine(sofa.AllInfo());

            Console.WriteLine("=========================================");

            Chair chair = new Chair(TypeChair.Type1, "Black", "поролон", "текстиль", false);
            Console.WriteLine(chair.Info());
            Console.WriteLine();
            Console.WriteLine(chair.AllInfo());
            
            Console.WriteLine("=========================================");
            
            Table table = new Table("дерево", TypeTable.Type1);
            Console.WriteLine(table.Info());
            Console.WriteLine();
            Console.WriteLine(table.AllInfo());


        }
    }
}
