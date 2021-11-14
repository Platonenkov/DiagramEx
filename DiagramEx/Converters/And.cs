using System;
using System.Globalization;
using System.Linq;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(And))]
    internal class And : MultiValueValueConverter
    {
        public bool NullDefaultValue { get; set; }

        /// <inheritdoc />
        protected override object Convert(object[]? vv, Type? t, object? p, CultureInfo? c) => vv?.Cast<bool>().All(v => v) ?? NullDefaultValue;
    }
}