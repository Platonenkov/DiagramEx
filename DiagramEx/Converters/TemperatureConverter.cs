using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(double?), typeof(Thickness))]
    [MarkupExtensionReturnType(typeof(TemperatureConverter))]
    internal class TemperatureConverter : ValueConverter
    {
        public bool ToCelsius { get; set; } = true;

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
        {
            if (v is not double value)
                return null;
            return ToCelsius 
                ? value * 1.8 + 32 
                : (value - 32) / 1.8;
        }

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
    }
    [ValueConversion(typeof(double?), typeof(Thickness))]
    [MarkupExtensionReturnType(typeof(BarPSIConverter))]
    internal class BarPSIConverter : ValueConverter
    {
        public bool ToPSI { get; set; } = true;

        private const double psi = 0.0689475728;

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
        {
            if (v is not double value)
                return null;
            return ToPSI
                ? value / psi
                : value * psi;
        }

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
    }
}