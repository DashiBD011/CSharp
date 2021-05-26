using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public abstract class Reception
    {
        public string Consultation { get; protected set; }
        public string Emergency { get; protected set; }
    }
}
