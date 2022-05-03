using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters;

[ValueConversion(typeof(double?), typeof(Thickness))]
[MarkupExtensionReturnType(typeof(MarginValueConverter))]
internal class MarginValueConverter : ValueConverter
{
    public bool Left { get; set; }
    public bool Right { get; set; }
    public bool Top { get; set; }
    public bool Bottom { get; set; }

    public double LeftValue { get; set; } = 0D;
    public double RightValue { get; set; } = 0D;
    public double TopValue { get; set; } = 0D;
    public double BottomValue { get; set; } = 0D;

    protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
    {
        if (v is not double value)
            return new Thickness(0);
        return new Thickness(
            left: Left ? value : LeftValue,
            right: Right ? value : RightValue,
            top: Top ? value : TopValue,
            bottom: Bottom ? value : BottomValue);
    }

    protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
}