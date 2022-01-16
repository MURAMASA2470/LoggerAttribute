using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidateSample.Source.Attributes
{
    public class LabelAttribute : Attribute
    {
        public string Name { get; set; }

        public LabelAttribute(string name)
        {
            this.Name = name;
        }
    }
}