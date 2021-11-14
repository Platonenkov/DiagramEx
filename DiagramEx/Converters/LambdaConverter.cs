using System;
using System.Globalization;
using System.Windows.Markup;

namespace DiagramEx.Converters
{
    [MarkupExtensionReturnType(typeof(LambdaConverter))]
    internal class LambdaConverter : ValueConverter
    {
        public delegate object? Converter(object? Value, Type? TargetValueType, object? Parameter, CultureInfo? Culture);

        public delegate object? ConverterBack(object? Value, Type? SourceValueType, object? Parameter, CultureInfo? Culture);

        private readonly Converter _To;

        private readonly ConverterBack? _From;

        public LambdaConverter(Converter To, ConverterBack? From = null)
        {
            _To = To;
            _From = From;
        }

        protected override object? Convert(object? v, Type? t, object? p, CultureInfo? c) => _To(v, t, p, c);

        protected override object? ConvertBack(object? v, Type? t, object? p, CultureInfo? c) => (_From ?? throw new NotSupportedException("Обратное преобразование не поддерживается")).Invoke(v, t, p, c);
    }
}