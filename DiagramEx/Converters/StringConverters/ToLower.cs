﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters.StringConverters
{
    [MarkupExtensionReturnType(typeof(ToLower)), ValueConversion(typeof(string), typeof(string))]
    internal class ToLower : ValueConverter
    {
        protected override object? Convert(object? v, Type t, object? p, CultureInfo c) => 
            (v as string ?? v?.ToString())?.ToLower(c);
    }
}