using System.Windows;
using System.Windows.Controls;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для RoundTextMarker.xaml
    /// </summary>
    public partial class RoundTextMarker : UserControl
    {
        public RoundTextMarker()
        {
            InitializeComponent();
        }
        #region Angle : double - Угол маркера

        /// <summary>Угол маркера</summary>
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register(
                nameof(Angle),
                typeof(double),
                typeof(RoundTextMarker),
                new PropertyMetadata(default(double)));

        /// <summary>Угол маркера</summary>
        public double Angle { get => (double)GetValue(AngleProperty); set => SetValue(AngleProperty, value); }

        #endregion

        #region TextMarkerMargin : Thickness - Отступ метки текста

        /// <summary>Отступ метки текста</summary>
        public static readonly DependencyProperty TextMarkerMarginProperty =
            DependencyProperty.Register(
                nameof(TextMarkerMargin),
                typeof(Thickness),
                typeof(RoundTextMarker),
                new PropertyMetadata(default(Thickness)));

        /// <summary>Отступ метки текста</summary>
        public Thickness TextMarkerMargin { get => (Thickness)GetValue(TextMarkerMarginProperty); set => SetValue(TextMarkerMarginProperty, value); }

        #endregion

        #region TextMarkerValue : string - Значение текстовой метки

        /// <summary>Значение текстовой метки</summary>
        public static readonly DependencyProperty TextMarkerValueProperty =
            DependencyProperty.Register(
                nameof(TextMarkerValue),
                typeof(string),
                typeof(RoundTextMarker),
                new PropertyMetadata(default(string)));

        /// <summary>Значение текстовой метки</summary>
        public string TextMarkerValue { get => (string)GetValue(TextMarkerValueProperty); set => SetValue(TextMarkerValueProperty, value); }

        #endregion

    }
}
