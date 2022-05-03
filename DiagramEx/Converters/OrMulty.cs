using System;
using System.Globalization;
using System.Linq;
using System.Windows.Markup;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(OrMulty))]
    public class OrMulty : MultiValueValueConverter 
    {
        protected override object Convert(object[] vv, Type t, object p, CultureInfo c) =>
            vv is { Length: > 0 }
            && vv[0] is bool
            && vv.OfType<bool>().Any(b => b);

        protected override object[] ConvertBack(object v, Type[] tt, object p, CultureInfo c) =>
            Enumerable
               .Repeat(v, tt.Length)
               .ToArray();
    }
}