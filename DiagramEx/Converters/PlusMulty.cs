using System;
using System.Globalization;
using System.Linq;
using System.Windows.Markup;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters;

[MarkupExtensionReturnType(typeof(PlusMulty))]
public class PlusMulty : MultiValueValueConverter 
{
    protected override object Convert(object[] vv, Type t, object p, CultureInfo c)
    {
        if (vv is not { Length: >= 1 } || vv.Contains(v => v is null))
            return null;

        if (vv.Length == 1)
            return vv[0];

        return (double)vv[0] + vv.Skip(1).Cast<double>().Sum();
    }

    protected override object[] ConvertBack(object v, Type[] tt, object p, CultureInfo c) =>
        Enumerable
           .Repeat(v, tt.Length)
           .ToArray();
}