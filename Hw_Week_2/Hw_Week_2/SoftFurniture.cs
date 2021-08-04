using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{

    public class SoftFurniture : Furniture
    {
        private string Filler { get; set; }      // Наполнитель
        private string Upholstery { get; set; }  // Обивка
        private bool is_folding { get; set; }    

        public SoftFurniture(string filler = null, string upholstery = null, bool is_folding = false) : base(Height: 0, Width: 0, Manufacturer: null)
        {
            Filler = filler;
            Upholstery = upholstery;
            this.is_folding = is_folding;
        }

        public SoftFurniture(double Height, double Width, string Manufacturer, string filler, string upholstery, bool is_folding) : base(Height, Width, Manufacturer)
        {

            Filler = filler;
            Upholstery = upholstery;
            this.is_folding = is_folding;
        }

        public string AllInfo()
        {
            return base.Info() + $"\nНаполнитель: {Filler}, Обивка: {Upholstery}, Раскладывается: " + (is_folding ? "да" : "нет");
        }
        public new string Info()
        {
            return $"\nНаполнитель: {Filler}, Обивка: {Upholstery}, Раскладывается: " + (is_folding ? "да" : "нет");
        }

    }
}
