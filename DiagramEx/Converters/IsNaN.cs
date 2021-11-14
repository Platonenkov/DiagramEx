using System;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(IsNaN))]
    [ValueConversion(typeof(double), typeof(bool?))]
    internal class IsNaN : DoubleToBool
    {
        public bool Inverted { get; set; }

        public IsNaN() { }

        public IsNaN(bool inverted) => Inverted = inverted;

        /// <inheritdoc />
        protected override bool? Convert(double v) => Inverted ^ v.IsNaN();
    }
}