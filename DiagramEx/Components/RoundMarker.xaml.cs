using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для RoundMarker.xaml
    /// </summary>
    public partial class RoundMarker : UserControl
    {
        public RoundMarker()
        {
            InitializeComponent();
        }

        #region Angle : double - Угол маркера

        /// <summary>Угол маркера</summary>
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register(
                nameof(Angle),
                typeof(double),
                typeof(RoundMarker),
                new PropertyMetadata(default(double)));

        /// <summary>Угол маркера</summary>
        public double Angle { get => (double)GetValue(AngleProperty); set => SetValue(AngleProperty, value); }

        #endregion

        #region Thickness : double - Толщина линии

        /// <summary>Толщина линии</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(RoundMarker),
                new PropertyMetadata(1D));

        /// <summary>Толщина линии</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

        #region MarkerHeight : double - Высота маркера

        /// <summary>Высота маркера</summary>
        public static readonly DependencyProperty MarkerHeightProperty =
            DependencyProperty.Register(
                nameof(MarkerHeight),
                typeof(double),
                typeof(RoundMarker),
                new PropertyMetadata(5D));

        /// <summary>Высота маркера</summary>
        public double MarkerHeight { get => (double)GetValue(MarkerHeightProperty); set => SetValue(MarkerHeightProperty, value); }

        #endregion

        #region MarkerTopMargin : double - Отступ маркера от границы

        /// <summary>Отступ маркера от границы</summary>
        public static readonly DependencyProperty MarkerTopMarginProperty =
            DependencyProperty.Register(
                nameof(MarkerTopMargin),
                typeof(double),
                typeof(RoundMarker),
                new PropertyMetadata(default(double)));

        /// <summary>Отступ маркера от границы</summary>
        public double MarkerTopMargin { get => (double)GetValue(MarkerTopMarginProperty); set => SetValue(MarkerTopMarginProperty, value); }

        #endregion

        #region TextMarkerMargin : Thickness - Отступ метки текста

        /// <summary>Отступ метки текста</summary>
        public static readonly DependencyProperty TextMarkerMarginProperty =
            DependencyProperty.Register(
                nameof(TextMarkerMargin),
                typeof(Thickness),
                typeof(RoundMarker),
                new PropertyMetadata(default(Thickness)));

        /// <summary>Отступ метки текста</summary>
        public Thickness TextMarkerMargin { get => (Thickness)GetValue(TextMarkerMarginProperty); set => SetValue(TextMarkerMarginProperty, value); }

        #endregion

        #region TextMarkerForeground : Brush - Цвет текстового маркера

        /// <summary>Цвет текстового маркера</summary>
        public static readonly DependencyProperty TextMarkerForegroundProperty =
            DependencyProperty.Register(
                nameof(TextMarkerForeground),
                typeof(Brush),
                typeof(RoundMarker),
                new PropertyMetadata(default(Brush)));

        /// <summary>Цвет текстового маркера</summary>
        public Brush TextMarkerForeground { get => (Brush)GetValue(TextMarkerForegroundProperty); set => SetValue(TextMarkerForegroundProperty, value); }

        #endregion

        #region TextMarkerVisibility : Visibility - Видимость текстовой метки

        /// <summary>Видимость текстовой метки</summary>
        public static readonly DependencyProperty TextMarkerVisibilityProperty =
            DependencyProperty.Register(
                nameof(TextMarkerVisibility),
                typeof(Visibility),
                typeof(RoundMarker),
                new PropertyMetadata(System.Windows.Visibility.Visible));

        /// <summary>Видимость текстовой метки</summary>
        public Visibility TextMarkerVisibility { get => (Visibility)GetValue(TextMarkerVisibilityProperty); set => SetValue(TextMarkerVisibilityProperty, value); }

        #endregion

        #region TextMarkerValue : string - Значение текстовой метки

        /// <summary>Значение текстовой метки</summary>
        public static readonly DependencyProperty TextMarkerValueProperty =
            DependencyProperty.Register(
                nameof(TextMarkerValue),
                typeof(string),
                typeof(RoundMarker),
                new PropertyMetadata(default(string)));

        /// <summary>Значение текстовой метки</summary>
        public string TextMarkerValue { get => (string)GetValue(TextMarkerValueProperty); set => SetValue(TextMarkerValueProperty, value); }

        #endregion
    }
}
