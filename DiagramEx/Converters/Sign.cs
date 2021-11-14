using System;
using System.Windows.Data;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(double), typeof(double))]
    internal class Sign : DoubleValueConverter
    {
        /// <inheritdoc />
        protected override double Convert(double v, double? p = null) => double.IsNaN(v) ? v : Math.Sign(v);

        /// <inheritdoc />
        protected override double ConvertBack(double v, double? p = null) => v;
    }
}