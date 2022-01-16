using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidateSample.Pages.P81020101
{
    public class P81020101_0_BizLogic
    {
        public P81020101_0_BizLogic()
        {
            var p = new P81020101_0_Property();

            p.Id = 100;

            var err = p.Validate();

            System.Console.WriteLine();
        }
    }
}