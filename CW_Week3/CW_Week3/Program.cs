using System;

namespace CW_Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.Form = "Square";
            Console.WriteLine(table.Form);
            Sofa sofa = new Sofa();
            sofa.Form = "Угловой";
            Console.WriteLine(sofa.Form);
        }
    }
}
