using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DiagramEx.Enums;

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

        #region RectifierNamePosition : PositionLR - Позиционирование Наименования

        /// <summary>Позиционирование Наименования</summary>
        public static readonly DependencyProperty RectifierNamePositionProperty =
            DependencyProperty.Register(
                nameof(RectifierNamePosition),
                typeof(PositionLR),
                typeof(Rectifier),
                new PropertyMetadata(default(PositionLR)));

        /// <summary>Позиционирование Наименования</summary>
        public PositionLR RectifierNamePosition { get => (PositionLR)GetValue(RectifierNamePositionProperty); set => SetValue(RectifierNamePositionProperty, value); }

        #endregion
        #region RectifierName : string - Наименование блока

        /// <summary>Наименование блока</summary>
        public static readonly DependencyProperty RectifierNameProperty =
            DependencyProperty.Register(
                nameof(RectifierName),
                typeof(string),
                typeof(Rectifier),
                new PropertyMetadata(default(string)));

        /// <summary>Наименование блока</summary>
        public string RectifierName { get => (string)GetValue(RectifierNameProperty); set => SetValue(RectifierNameProperty, value); }

        #endregion
        #region RectifierNameBrush : Brush - Цвет наименования

        /// <summary>Цвет наименования</summary>
        public static readonly DependencyProperty RectifierNameBrushProperty =
            DependencyProperty.Register(
                nameof(RectifierNameBrush),
                typeof(Brush),
                typeof(Rectifier),
                new PropertyMetadata(default(Brush)));

        /// <summary>Цвет наименования</summary>
        public Brush RectifierNameBrush { get => (Brush)GetValue(RectifierNameBrushProperty); set => SetValue(RectifierNameBrushProperty, value); }

        #endregion

        #region Size : double - Размер блока

        /// <summary>Размер блока</summary>
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(
                nameof(Size),
                typeof(double),
                typeof(Rectifier),
                new PropertyMetadata(20D));

        /// <summary>Размер блока</summary>
        public double Size { get => (double)GetValue(SizeProperty); set => SetValue(SizeProperty, value); }

        #endregion
        public Rectifier()
        {
            InitializeComponent();
        }

    }
}
