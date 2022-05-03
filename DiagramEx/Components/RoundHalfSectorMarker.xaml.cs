using System.Windows;
using System.Windows.Controls;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для RoundHalfSectorMarker.xaml
    /// </summary>
    public partial class RoundHalfSectorMarker : UserControl
    {
        public RoundHalfSectorMarker()
        {
            InitializeComponent();
        }
        #region Angle : double - Угол маркера

        /// <summary>Угол маркера</summary>
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register(
                nameof(Angle),
                typeof(double),
                typeof(RoundHalfSectorMarker),
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
                typeof(RoundHalfSectorMarker),
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
                typeof(RoundHalfSectorMarker),
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
                typeof(RoundHalfSectorMarker),
                new PropertyMetadata(default(double)));

        /// <summary>Отступ маркера от границы</summary>
        public double MarkerTopMargin { get => (double)GetValue(MarkerTopMarginProperty); set => SetValue(MarkerTopMarginProperty, value); }

        #endregion

    }
}
