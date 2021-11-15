using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(bool?), typeof(Thickness))]
    [MarkupExtensionReturnType(typeof(ThicknessValueConverter))]
    internal class ThicknessValueConverter : ValueConverter
    {
        public bool Left { get; set; }

        public bool Right { get; set; }
        public bool Top { get; set; }

        public bool Bottom { get; set; }

        public double Multiply { get; set; } = 1D;

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
        {
            if (v is not double value)
                return null;
            value = value * Multiply;
            var thickness = new Thickness(left: Left ? value : 0, right: Right ? value : 0, top: Top ? value : 0, bottom: Bottom ? value : 0);
            return thickness;
        }

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
    }
}