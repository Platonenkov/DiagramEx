using System.Windows;
using System.Windows.Controls;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для GeneratorIcon.xaml
    /// </summary>
    public partial class GeneratorIcon:UserControl
    {
        public GeneratorIcon()
        {
            InitializeComponent();
        }
        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(GeneratorIcon),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

    }
}
