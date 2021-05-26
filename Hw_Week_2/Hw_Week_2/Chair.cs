using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{
    public enum TypeChair
    {
        Type1, Type2, Type3
    }

    class Chair:Furniture
    {
        public TypeChair Type { get; set; }

    }
}
