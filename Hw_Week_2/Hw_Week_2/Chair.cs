using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{
    public enum TypeChair
    {
        Type1, Type2, Type3
    }

    public class Chair:SoftFurniture
    {
        private TypeChair Type { get; set; }
        private string Colour { get; set; }

        public Chair(TypeChair Type = 0, string Colour = null):base(filler: null, upholstery: null, is_folding: false)
        {
            this.Type = Type;
            this.Colour = Colour;
        }
        public Chair(TypeChair Type, string Colour, string filler, string upholstery, bool is_folding) : base(filler, upholstery, is_folding)
        {
            this.Type = Type;
            this.Colour = Colour;
        }
        public Chair(TypeChair Type, string Colour, double Height, double Width, string Manufacturer, string filler, string upholstery, bool is_folding): base(Height, Width, Manufacturer, filler, upholstery, is_folding)
        {
            this.Type = Type;
            this.Colour = Colour;
        }

        public new string AllInfo()
        {
            return base.AllInfo() + $"\nТип стула: {Type}, Цвет: { Colour}";
        }
        public new string Info()
        {
            return $"Тип стула: {Type}, Цвет: {Colour}";
        }
    }
}
