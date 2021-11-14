using System;
using System.Globalization;
using System.Linq;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(Or))]
    internal class Or : MultiValueValueConverter
    {
        /// <inheritdoc />
        protected override object? Convert(object[]? vv, Type? t, object? p, CultureInfo? c) => vv?.Cast<bool>().Any(v => v);
    }
}