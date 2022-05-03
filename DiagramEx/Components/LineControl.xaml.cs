using System.Windows;
using System.Windows.Controls;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для LineControl.xaml
    /// </summary>
    public partial class LineControl : UserControl
    {
        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

        public LineControl()
        {
            InitializeComponent();
        }

        #region LeftVisible : bool - Отображение левых элементов

        /// <summary>Отображение левых элементов</summary>
        public static readonly DependencyProperty LeftVisibleProperty =
            DependencyProperty.Register(
                nameof(LeftVisible),
                typeof(bool),
                typeof(LineControl),
                new PropertyMetadata(true));

        /// <summary>Отображение левых элементов</summary>
        public bool LeftVisible { get => (bool)GetValue(LeftVisibleProperty); set => SetValue(LeftVisibleProperty, value); }

        #endregion
        #region RightVisible : bool - Отображение правых элементов

        /// <summary>Отображение правых элементов</summary>
        public static readonly DependencyProperty RightVisibleProperty =
            DependencyProperty.Register(
                nameof(RightVisible),
                typeof(bool),
                typeof(LineControl),
                new PropertyMetadata(true));

        /// <summary>Отображение правых элементов</summary>
        public bool RightVisible { get => (bool)GetValue(RightVisibleProperty); set => SetValue(RightVisibleProperty, value); }

        #endregion


        #region BottomLeftHeight : double - Размер нижней левой выноски

        /// <summary>Размер нижней левой выноски</summary>
        public static readonly DependencyProperty BottomLeftHeightProperty =
            DependencyProperty.Register(
                nameof(BottomLeftHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер нижней левой выноски</summary>
        public double BottomLeftHeight { get => (double) GetValue(BottomLeftHeightProperty); set => SetValue(BottomLeftHeightProperty, value); }

        #endregion
        #region TopLeftHeight : double - Размер верхней левой выноски

        /// <summary>Размер верхней левой выноски</summary>
        public static readonly DependencyProperty TopLeftHeightProperty =
            DependencyProperty.Register(
                nameof(TopLeftHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер верхней левой выноски</summary>
        public double TopLeftHeight { get => (double) GetValue(TopLeftHeightProperty); set => SetValue(TopLeftHeightProperty, value); }

        #endregion
        #region HLeftLineWidth : double - Размер центральной левой выноски

        /// <summary>Размер центральной левой выноски</summary>
        public static readonly DependencyProperty HLeftLineWidthProperty =
            DependencyProperty.Register(
                nameof(HLeftLineWidth),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер центральной левой выноски</summary>
        public double HLeftLineWidth { get => (double) GetValue(HLeftLineWidthProperty); set => SetValue(HLeftLineWidthProperty, value); }

        #endregion
        #region BottomRightHeight : double - Размер нижней правой выноски

        /// <summary>Размер нижней правой выноски</summary>
        public static readonly DependencyProperty BottomRightHeightProperty =
            DependencyProperty.Register(
                nameof(BottomRightHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер нижней правой выноски</summary>
        public double BottomRightHeight { get => (double) GetValue(BottomRightHeightProperty); set => SetValue(BottomRightHeightProperty, value); }

        #endregion
        #region TopRightHeight : double - Размер верхней правой выноски

        /// <summary>Размер верхней правой выноски</summary>
        public static readonly DependencyProperty TopRightHeightProperty =
            DependencyProperty.Register(
                nameof(TopRightHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер верхней правой выноски</summary>
        public double TopRightHeight { get => (double) GetValue(TopRightHeightProperty); set => SetValue(TopRightHeightProperty, value); }

        #endregion
        #region HRightLineWidth : double - Размер центральной правой выноски

        /// <summary>Размер центральной правой выноски</summary>
        public static readonly DependencyProperty HRightLineWidthProperty =
            DependencyProperty.Register(
                nameof(HRightLineWidth),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер центральной правой выноски</summary>
        public double HRightLineWidth { get => (double) GetValue(HRightLineWidthProperty); set => SetValue(HRightLineWidthProperty, value); }

        #endregion
        #region BottomCentralHeight : double - Размер нижней центральной выноски

        /// <summary>Размер нижней центральной выноски</summary>
        public static readonly DependencyProperty BottomCentralHeightProperty =
            DependencyProperty.Register(
                nameof(BottomCentralHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер нижней центральной выноски</summary>
        public double BottomCentralHeight { get => (double) GetValue(BottomCentralHeightProperty); set => SetValue(BottomCentralHeightProperty, value); }

        #endregion
        #region TopCentralHeight : double - Размер верхней центральной выноски

        /// <summary>Размер верхней центральной выноски</summary>
        public static readonly DependencyProperty TopCentralHeightProperty =
            DependencyProperty.Register(
                nameof(TopCentralHeight),
                typeof(double),
                typeof(LineControl),
                new PropertyMetadata(20D));

        /// <summary>Размер верхней центральной выноски</summary>
        public double TopCentralHeight { get => (double) GetValue(TopCentralHeightProperty); set => SetValue(TopCentralHeightProperty, value); }

        #endregion
    }
}
