using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(bool?), typeof(Visibility))]
    [MarkupExtensionReturnType(typeof(Bool2Visibility))]
    internal class Bool2Visibility : ValueConverter
    {
        public bool Inverted { get; set; }

        public bool Collapsed { get; set; }

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c) =>
            v switch
            {
                null => null,
                Visibility => v,
                true => !Inverted ? Visibility.Visible : Collapsed ? Visibility.Collapsed : Visibility.Hidden,
                false => Inverted ? Visibility.Visible : Collapsed ? Visibility.Collapsed : Visibility.Hidden,
                _ => throw new NotSupportedException()
            };

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) =>
            v switch
            {
                null => null,
                bool => v,
                Visibility.Visible => !Inverted,
                Visibility.Hidden => Inverted,
                Visibility.Collapsed => Inverted,
                _ => throw new NotSupportedException()
            };
    }
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