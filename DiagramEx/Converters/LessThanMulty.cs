using System;
using System.Globalization;
using System.Linq;
using System.Windows.Markup;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(LessThanMulty))]
    public class LessThanMulty : MultiValueValueConverter 
    {
        protected override object Convert(object[] vv, Type t, object p, CultureInfo c)
        {
            if (vv is not { Length: > 1 })
                return false;
            var first = (double?)vv[0];
            if (first is null)
                return false;
            var other = vv[1..];
            return !other.Any(v => (double?)v <= first);
        }

        protected override object[] ConvertBack(object v, Type[] tt, object p, CultureInfo c) =>
            Enumerable
               .Repeat(v, tt.Length)
               .ToArray();
    }
}