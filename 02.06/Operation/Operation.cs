using System;
using System.Collections.Generic;
using System.Text;

namespace Operation
{
    public class Operation
    {
        public int Calc(int num1, int num2, Operations op)
        {
            return op.Invoke(num1, num2);
            // ?. проверяет экземпляр делегата на null
        }
    }
}
