using System.Windows;
using System.Windows.Controls;
using DiagramEx.Enums.Arrows;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для ArrowControl.xaml
    /// </summary>
    public partial class ArrowControl : UserControl
    {
        public ArrowControl()
        {
            InitializeComponent();
        }
        #region ArrowOrientation : ArrowOrientationEnum - Направление стрелки

        /// <summary>Направление стрелки</summary>
        public static readonly DependencyProperty ArrowOrientationProperty =
            DependencyProperty.Register(
                nameof(ArrowOrientation),
                typeof(ArrowOrientationEnum),
                typeof(ArrowControl),
                new PropertyMetadata(ArrowOrientationEnum.Top));

        /// <summary>Направление стрелки</summary>
        public ArrowOrientationEnum ArrowOrientation { get => (ArrowOrientationEnum)GetValue(ArrowOrientationProperty); set => SetValue(ArrowOrientationProperty, value); }

        #endregion

        #region ArrowSize : double - Размер стрелки

        /// <summary>Размер стрелки</summary>
        public static readonly DependencyProperty ArrowSizeProperty =
            DependencyProperty.Register(
                nameof(ArrowSize),
                typeof(double),
                typeof(ArrowControl),
                new PropertyMetadata(15D));

        /// <summary>Размер стрелки</summary>
        public double ArrowSize { get => (double)GetValue(ArrowSizeProperty); set => SetValue(ArrowSizeProperty, value); }

        #endregion

        #region Thickness : double - Толщина линий

        /// <summary>Толщина линий</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(ArrowControl),
                new PropertyMetadata(1D));

        /// <summary>Толщина линий</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

    }
}
