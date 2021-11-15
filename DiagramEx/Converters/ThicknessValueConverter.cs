using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using DiagramEx.Enums;

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
        public double LeftMultiply { get; set; } = 1D;
        public double RightMultiply { get; set; } = 1D;
        public double TopMultiply { get; set; } = 1D;
        public double BottomMultiply { get; set; } = 1D;

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
        {
            if (v is not double value)
                return null;
            var thickness = new Thickness(
                left: Left ? value * LeftMultiply : 0,
                right: Right ? value * RightMultiply : 0,
                top: Top ? value * TopMultiply : 0,
                bottom: Bottom ? value * BottomMultiply : 0);
            return thickness;
        }

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
    }
}