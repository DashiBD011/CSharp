using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{
    public enum TypeTable
    {
        Type1,Type2, Type3
    }
    public class Table : Furniture
    {
        private string Material { get; set; }
        private TypeTable type { get; set; }

        public Table(string Material = null, TypeTable type = 0) : base(Height: 0, Width: 0, Manufacturer: null)
        {
            this.Material = Material;
            this.type = type;
        }
        public Table(string Material, TypeTable type, double Height, double Width, string Manufacturer) : base(Height, Width, Manufacturer)
        {
            this.Material = Material;
            this.type = type;
        }

        public string AllInfo()
        {
            return base.Info() + $"\nМатериал: {Material}, Тип стола: {type}";
        }
        public new string Info()
        {
            return $"Материал: {Material}, Тип стола: {type}";
        }
    }
}
