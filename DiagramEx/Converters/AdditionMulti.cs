﻿using System.Linq;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(AdditionMulti))]
    internal class AdditionMulti : MultiDoubleValueValueConverter
    {
        /// <inheritdoc />
        protected override double Convert(double[]? vv) => vv?.Sum() ?? double.NaN;
    }
}