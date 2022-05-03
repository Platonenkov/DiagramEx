using MathCore.WPF.Converters.Base;

using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(AndMulty))]
    public class AndMulty : MultiValueValueConverter
    {
        protected override object Convert(object[] vv, Type t, object p, CultureInfo c)
        {
            if (vv is null || vv.Length == 0 || !(vv[0] is bool)) return false;
            return vv.OfType<bool>().Aggregate(true, (P, v) => P && v);
        }

        protected override object[] ConvertBack(object v, Type[] tt, object p, CultureInfo c) => Enumerable.Repeat(v, tt.Length).ToArray();
    }
}