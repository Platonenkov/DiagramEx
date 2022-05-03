using System.Windows;
using System.Windows.Controls;
using DiagramEx.Enums.Arrows;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для SimpleArrow.xaml
    /// </summary>
    public partial class SimpleArrow : UserControl
    {
        public SimpleArrow()
        {
            InitializeComponent();
        }

        #region ArrowDirection : ArrowDirectionEnum - Направление стрелки

        /// <summary>Направление стрелки</summary>
        public static readonly DependencyProperty ArrowDirectionProperty =
            DependencyProperty.Register(
                nameof(ArrowDirection),
                typeof(ArrowDirectionEnum),
                typeof(SimpleArrow),
                new PropertyMetadata(default(ArrowDirectionEnum)));

        /// <summary>Направление стрелки</summary>
        public ArrowDirectionEnum ArrowDirection { get => (ArrowDirectionEnum)GetValue(ArrowDirectionProperty); set => SetValue(ArrowDirectionProperty, value); }

        #endregion

        #region Thickness : double - Толщина линий

        /// <summary>Толщина линий</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(SimpleArrow),
                new PropertyMetadata(1D));

        /// <summary>Толщина линий</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

    }
}
