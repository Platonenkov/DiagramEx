using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global
// ReSharper disable MemberCanBePrivate.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(ArrayElement))]
    [ValueConversion(typeof(IEnumerable), typeof(object))]
    internal class ArrayElement : ValueConverter
    {
        public int Index { get; set; }

        public ArrayElement() { }

        public ArrayElement(int Index) => this.Index = Index;

        /// <inheritdoc />
        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c) => (v as IEnumerable)?.Cast<object>().ElementAtOrDefault(Index);
    }
}