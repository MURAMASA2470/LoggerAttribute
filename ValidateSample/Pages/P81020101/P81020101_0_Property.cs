using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValidateSample.Source.Attributes;
//using ValidateSample.Source.Attributes;

namespace ValidateSample.Pages.P81020101
{
    public class P81020101_0_Property : IProperty
    {
        [Label("ID")]
        [Required, Between(0, 100)]
        public int Id { get; set; }

        [Label("名前")]
        [Required]
        public string Name { get; set; }

        //public string Validate()
        //{
        //    throw new NotImplementedException();
        //}
    }
}