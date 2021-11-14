using System;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(IsNegative))]
    [ValueConversion(typeof(double), typeof(bool?))]
    internal class IsNegative : DoubleToBool
    {
        /// <inheritdoc />
        protected override bool? Convert(double v) => v.IsNaN() ? null : v < 0;
    }
}