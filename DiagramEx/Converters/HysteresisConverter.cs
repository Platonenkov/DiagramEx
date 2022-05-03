using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using MathCore.WPF.Converters.Base;

namespace DiagramEx.Converters;

[ValueConversion(typeof(double?), typeof(SolidColorBrush))]
[MarkupExtensionReturnType(typeof(HysteresisConverter))]
internal class HysteresisConverter : ValueConverter
{
    /// <summary> Минимальное значение петли </summary>
    public double MinValue { get; set; }
    /// <summary> Максимальное значение петли </summary>
    public double MaxValue { get; set; }
    ///// <summary> Флаг минимального порога </summary>
    //private bool minFlag { get; set; }
    /// <summary> флаг максимального порога </summary>
    private bool maxFlag { get; set; }

    public SolidColorBrush LowValueColor { get; set; } = new(Colors.Orange);
    public SolidColorBrush HightValueColor { get; set; } = new(Colors.Green);
    protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c)
    {
        if (v is not double value)
            return LowValueColor;
        if (value < MinValue)
        {
            //minFlag = false;
            maxFlag = false;
            return LowValueColor;
        }

        if (value > MinValue && value < MaxValue && !maxFlag)
        {
            //minFlag = true;
            return LowValueColor;
        }
        if (value > MinValue && value < MaxValue && maxFlag)
            return HightValueColor;

        if (value > MaxValue)
        {
            //minFlag = true;
            maxFlag = true;
            return HightValueColor;
        }


        throw new ArgumentOutOfRangeException();
    }

    protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => Binding.DoNothing;
}