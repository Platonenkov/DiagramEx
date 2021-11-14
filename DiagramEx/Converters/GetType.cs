using System;
using System.Globalization;
using System.Windows.Data;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(object), typeof(Type))]
    internal class GetType : ValueConverter
    {
        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c) => v?.GetType();
    }
}
