using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_Week_2
{
    public class Sofa:SoftFurniture
    {
        public int AmountPeople { get; set; }
        public Sofa(int AmountPeople = 0 ):base(filler:null,upholstery:null,is_folding:false)
        {
            this.AmountPeople = AmountPeople;
        }
        public Sofa(int AmountPeople, double Height, double Width, string Manufacturer, string filler, string upholstery, bool is_folding):base(Height,Width,Manufacturer,filler,upholstery,is_folding)
        {
            this.AmountPeople = AmountPeople;
        }

        public new string AllInfo()
        {
            return base.Info() + $"\nКоличество мест: {AmountPeople}";
        }
        public new string Info()
        {
            return $"\nКоличество мест: {AmountPeople}";
        }

    }
}
