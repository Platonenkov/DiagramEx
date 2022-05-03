using System.Windows;
using System.Windows.Controls;
using DiagramEx.Enums.Lines;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для Line.xaml
    /// </summary>
    public partial class SimpleLine : UserControl
    {
        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(SimpleLine),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

        #region LineOrientation : Orientation - Ориентация

        /// <summary>Ориентация</summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register(
                nameof(Orientation),
                typeof(LineOrientation),
                typeof(SimpleLine),
                new PropertyMetadata(default(LineOrientation)));

        /// <summary>Ориентация</summary>
        public LineOrientation Orientation { get => (LineOrientation)GetValue(OrientationProperty); set => SetValue(OrientationProperty, value); }

        #endregion

        public SimpleLine()
        {
            InitializeComponent();
        }

        #region LineFill : LineFillType - Заполнение по горизонтали

        /// <summary>Заполнение по горизонтали</summary>
        public static readonly DependencyProperty LineFillProperty =
            DependencyProperty.Register(
                nameof(LineFill),
                typeof(LineFillType),
                typeof(SimpleLine),
                new PropertyMetadata(default(LineFillType)));

        /// <summary>Заполнение по горизонтали</summary>
        public LineFillType LineFill { get => (LineFillType)GetValue(LineFillProperty); set => SetValue(LineFillProperty, value); }

        #endregion

    }
}
