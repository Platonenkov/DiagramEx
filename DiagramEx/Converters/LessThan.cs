using System;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(LessThan))]
    [ValueConversion(typeof(double), typeof(bool?))]
    internal class LessThan : DoubleToBool
    {
        public double Value { get; set; } = double.PositiveInfinity;

        public LessThan() { }

        public LessThan(double value) => Value = value;

        protected override bool? Convert(double v) => v.IsNaN() ? null : v < Value;
    }
}