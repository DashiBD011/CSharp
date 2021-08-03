using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Pencil
{
    public enum Colour
    {
        Black, Red, Blue, Green, Gray, Yellow
    }
    public enum Condition
    {
        broken, blunt, sharpened
    }
    public class Pencil
    {
        public double RodLength { get; set; }
        private string Material { get; set; }
        private Colour colour { get; set; }
        private Condition condition { get; set; }
        private bool have_an_eraser { get; set; }
        private double Price { get; set; }

        public static string CountryofOrigin;
        public static double LeadDiameter;

        //public Message message;
        

        static Pencil()
        {
            CountryofOrigin = "China";
            LeadDiameter = 2.0;
        }
        public Pencil()
        {
            RodLength = 175;
            Material = "wood";
            condition = Condition.sharpened;
            colour = Colour.Gray;
            have_an_eraser = false;
            Price = 3;
        }
        public Pencil(Colour colour, bool have_an_eraser, double Price)
        {
            this.colour = colour;
            this.have_an_eraser = have_an_eraser;
            this.Price = Price;
        }
        public Pencil(double RodLength, string Material,Condition condition,Colour colour, bool have_an_eraser, double Price)
        {
            this.RodLength = RodLength;
            this.Material = Material;
            this.condition = condition;
            this.colour = colour;
            this.have_an_eraser = have_an_eraser;
            this.Price = Price;
        }
        public void Info()
        {
            Console.WriteLine
                (
                $"Длина стержня: {RodLength}\nМатериал: {Material}\nСостояние: {condition}" +
                $"\nЦвет: {colour}\nНаличие ластика: {have_an_eraser}\nЦена: {Price} руб"
                );
        }
       
    }
}
