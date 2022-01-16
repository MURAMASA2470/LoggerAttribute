using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidateSample.Source.Attributes
{
    public class BetweenAttribute : Attribute
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public BetweenAttribute(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}