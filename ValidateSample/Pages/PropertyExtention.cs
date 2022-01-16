using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using ValidateSample.Source.Attributes;
using ValidateSample.Source.Const;

namespace ValidateSample.Pages
{
    public static class PropertyExtention
    {
        public static string Validate<T>(this T obj) where T : IProperty
        {
            var msg = string.Empty;
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                var label = (prop.GetCustomAttribute(typeof(LabelAttribute)) as LabelAttribute)?.Name ?? prop.Name;
                
                foreach (var attribute in prop.GetCustomAttributes())
                {
                    switch (attribute)
                    {
                        case RequiredAttribute attr:
                            if (prop.GetValue(obj) == null)
                            {
                                return string.Format(Message.MSG0001, label);
                            }
                            break;

                        case BetweenAttribute attr:
                            if (prop.GetValue(obj) as int? < attr.Min || prop.GetValue(obj) as int? > attr.Max)
                            {
                                return string.Format(Message.MSG0002, label, attr.Min, attr.Max);
                            }
                            break;
                    }
                }
            }

            return string.Empty;
        }
    }
}