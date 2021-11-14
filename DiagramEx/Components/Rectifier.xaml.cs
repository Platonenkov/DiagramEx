using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для Rectifier.xaml
    /// </summary>
    public partial class Rectifier : UserControl
    {
        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(Rectifier),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion


        public Rectifier()
        {
            InitializeComponent();
        }

    }
}
