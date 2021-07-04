using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{
    public class Furniture
    {
        private double Height { get; set; }
        private double Width { get; set; }
        private string Manufacturer { get; set; }


        public Furniture(double Height = 0, double Width = 0, string Manufacturer = null)
        {
            this.Height = Height;
            this.Width = Width;
            this.Manufacturer = Manufacturer;
        }
        public string Info()
        {
            return $"В х Ш: {Height} x {Width}, Производитель: {Manufacturer} ";
        }
    }
}
