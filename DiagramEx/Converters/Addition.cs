using System.Windows.Markup;

// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    /// <summary>Преобразователь сложения значения с вещественным числом</summary>
    [MarkupExtensionReturnType(typeof(Addition))]
    internal class Addition : SimpleDoubleValueConverter
    {
        public Addition() : this(0) { }

        public Addition(double P) : base(P, (v, p) => v + p, (r, p) => r - p) { }
    }
}