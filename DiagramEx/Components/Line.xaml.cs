using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using DiagramEx.Enums;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для Line.xaml
    /// </summary>
    public partial class Line : UserControl
    {
        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(Line),
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
                typeof(Line),
                new PropertyMetadata(default(LineOrientation)));

        /// <summary>Ориентация</summary>
        public LineOrientation Orientation { get => (LineOrientation)GetValue(OrientationProperty); set => SetValue(OrientationProperty, value); }

        #endregion


        public Line()
        {
            InitializeComponent();
        }

        #region LineFill : LineFillType - Заполнение по горизонтали

        /// <summary>Заполнение по горизонтали</summary>
        public static readonly DependencyProperty LineFillProperty =
            DependencyProperty.Register(
                nameof(LineFill),
                typeof(LineFillType),
                typeof(Line),
                new PropertyMetadata(default(LineFillType)));

        /// <summary>Заполнение по горизонтали</summary>
        public LineFillType LineFill { get => (LineFillType)GetValue(LineFillProperty); set => SetValue(LineFillProperty, value); }

        #endregion

    }
}
