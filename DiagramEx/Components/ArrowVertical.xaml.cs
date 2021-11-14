using System.Windows;
using System.Windows.Controls;
using DiagramEx.Enums;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для ArrowTop.xaml
    /// </summary>
    public partial class ArrowVertical : UserControl
    {
        public ArrowVertical()
        {
            InitializeComponent();
        }

        #region Arrow : ArrowVerticalStyle - Направление стрелки

        /// <summary>Направление стрелки</summary>
        public static readonly DependencyProperty ArrowProperty =
            DependencyProperty.Register(
                nameof(Arrow),
                typeof(ArrowVerticalStyle),
                typeof(ArrowVertical),
                new PropertyMetadata(default(ArrowVerticalStyle)));

        /// <summary>Направление стрелки</summary>
        public ArrowVerticalStyle Arrow { get => (ArrowVerticalStyle)GetValue(ArrowProperty); set => SetValue(ArrowProperty, value); }

        #endregion

        #region ArrowSizeWidth : double - Размер стрелки

        /// <summary>Размер стрелки</summary>
        public static readonly DependencyProperty ArrowSizeWidthProperty =
            DependencyProperty.Register(
                nameof(ArrowSizeWidth),
                typeof(double),
                typeof(ArrowVertical),
                new PropertyMetadata(10D));

        /// <summary>Размер стрелки</summary>
        public double ArrowSizeWidth { get => (double)GetValue(ArrowSizeWidthProperty); set => SetValue(ArrowSizeWidthProperty, value); }

        #endregion
        #region ArrowSizeHeight : double - Размер стрелки

        /// <summary>Размер стрелки</summary>
        public static readonly DependencyProperty ArrowSizeHeightProperty =
            DependencyProperty.Register(
                nameof(ArrowSizeHeight),
                typeof(double),
                typeof(ArrowVertical),
                new PropertyMetadata(15D));

        /// <summary>Размер стрелки</summary>
        public double ArrowSizeHeight { get => (double)GetValue(ArrowSizeHeightProperty); set => SetValue(ArrowSizeHeightProperty, value); }

        #endregion

        #region Thickness : double - Толщина линий

        /// <summary>Толщина линий</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(ArrowVertical),
                new PropertyMetadata(1D));

        /// <summary>Толщина линий</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion
    }
}
