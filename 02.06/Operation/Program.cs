using System;

namespace Operation
{
    class Program
    {
        static void Main()
        {
            var operation = new Operation();
            var result = operation.Calc(num1: 5, num2: 4, Add);
            Console.WriteLine($"sum = {result}");
            
            result = operation.Calc(num1: 5, num2: 4, Max);
            Console.WriteLine($"sum = {result}");


        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        static int Max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
