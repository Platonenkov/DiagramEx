using System;
using System.Collections;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(MultiValuesToCompositeCollection))]
    internal class MultiValuesToCompositeCollection : MultiValueValueConverter
    {
        protected override object? Convert(object[]? vv, Type? t, object? p, CultureInfo? c)
        {
            if (vv is null) return null;
            var collection = new CompositeCollection();
            foreach (var value in vv)
            {
                var src = value is IEnumerable enumerable 
                    ? new CollectionContainer { Collection = enumerable } 
                    : value;
                collection.Add(src);
            }

            return collection;
        }
    }
}
