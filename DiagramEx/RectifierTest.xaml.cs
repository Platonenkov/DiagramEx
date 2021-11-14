using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiagramEx
{
    /// <summary>
    /// Логика взаимодействия для Rectifier.xaml
    /// </summary>
    public partial class RectifierTest : UserControl
    {
        //#region RectifierNameBrush : Brush - Цвет текста Наименования

        ///// <summary>Цвет текста Наименования</summary>
        //public static readonly DependencyProperty RectifierNameBrushProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierNameBrush),
        //        typeof(Brush),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(Brush)));

        ///// <summary>Цвет текста Наименования</summary>
        //public Brush RectifierNameBrush { get => (Brush)GetValue(RectifierNameBrushProperty); set => SetValue(RectifierNameBrushProperty, value); }

        //#endregion
        //#region RectifierName : string - Наименование блока

        ///// <summary>Наименование блока</summary>
        //public static readonly DependencyProperty RectifierNameProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierName),
        //        typeof(string),
        //        typeof(RectifierTest),
        //        new PropertyMetadata("TRU"));

        ///// <summary>Наименование блока</summary>
        //public string RectifierName { get => (string)GetValue(RectifierNameProperty); set => SetValue(RectifierNameProperty, value); }

        //#endregion

        #region LeftBranchVisible : Visibility - Видимость левой ветки

        /// <summary>Видимость левой ветки</summary>
        public static readonly DependencyProperty LeftBranchVisibleProperty =
            DependencyProperty.Register(
                nameof(LeftBranchVisible),
                typeof(Visibility),
                typeof(RectifierTest),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость левой ветки</summary>
        public Visibility LeftBranchVisible { get => (Visibility)GetValue(LeftBranchVisibleProperty); set => SetValue(LeftBranchVisibleProperty, value); }

        #endregion
        #region RightBranchVisible : Visibility - Видимость правой ветки

        /// <summary>Видимость правой ветки</summary>
        public static readonly DependencyProperty RightBranchVisibleProperty =
            DependencyProperty.Register(
                nameof(RightBranchVisible),
                typeof(Visibility),
                typeof(RectifierTest),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость правой ветки</summary>
        public Visibility RightBranchVisible { get => (Visibility)GetValue(RightBranchVisibleProperty); set => SetValue(RightBranchVisibleProperty, value); }

        #endregion
        #region CentralBranchVisible : Visibility - Видимость центральной ветки

        /// <summary>Видимость центральной ветки</summary>
        public static readonly DependencyProperty CentralBranchVisibleProperty =
            DependencyProperty.Register(
                nameof(CentralBranchVisible),
                typeof(Visibility),
                typeof(RectifierTest),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость центральной ветки</summary>
        public Visibility CentralBranchVisible { get => (Visibility)GetValue(CentralBranchVisibleProperty); set => SetValue(CentralBranchVisibleProperty, value); }

        #endregion

        #region Thickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(RectifierTest),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

        #region RectifierBlockSize : double - Высота блока выпрямителя

        /// <summary>Высота блока выпрямителя</summary>
        public static readonly DependencyProperty RectifierBlockSizeProperty =
            DependencyProperty.Register(
                nameof(RectifierBlockSize),
                typeof(double),
                typeof(RectifierTest),
                new PropertyMetadata(20D));

        /// <summary>Высота блока выпрямителя</summary>
        public double RectifierBlockSize { get => (double)GetValue(RectifierBlockSizeProperty); set => SetValue(RectifierBlockSizeProperty, value); }

        #endregion

        #region RectifierBottomBranchSize : double - Размер нижнего питания

        /// <summary>Размер нижнего питания</summary>
        public static readonly DependencyProperty RectifierBottomBranchSizeProperty =
            DependencyProperty.Register(
                nameof(RectifierBottomBranchSize),
                typeof(double),
                typeof(RectifierTest),
                new PropertyMetadata(20D));

        /// <summary>Размер нижнего питания</summary>
        public double RectifierBottomBranchSize { get => (double)GetValue(RectifierBottomBranchSizeProperty); set => SetValue(RectifierBottomBranchSizeProperty, value); }

        #endregion

        //#region RectifierNamePosition : Dock - положение имени относительно блока

        ///// <summary>положение имени относительно блока</summary>
        //public static readonly DependencyProperty RectifierNamePositionProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierNamePosition),
        //        typeof(Dock),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(Dock)));

        ///// <summary>положение имени относительно блока</summary>
        //public Dock RectifierNamePosition { get => (Dock)GetValue(RectifierNamePositionProperty); set => SetValue(RectifierNamePositionProperty, value); }

        //#endregion
        //#region RectifierCurrentPosition : Dock - положение значения тока относительно блока

        ///// <summary>положение значения тока относительно блока</summary>
        //public static readonly DependencyProperty RectifierCurrentPositionProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierCurrentPosition),
        //        typeof(Dock),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(Dock)));

        ///// <summary>положение значения тока относительно блока</summary>
        //public Dock RectifierCurrentPosition { get => (Dock)GetValue(RectifierCurrentPositionProperty); set => SetValue(RectifierCurrentPositionProperty, value); }

        //#endregion


        public RectifierTest()
        {
            InitializeComponent();
        }


        //#region RectifierCurrentValue : int - Сила тока

        ///// <summary>Сила тока</summary>
        //public static readonly DependencyProperty RectifierCurrentValueProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierCurrentValue),
        //        typeof(int),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(int)));

        ///// <summary>Сила тока</summary>
        //public int RectifierCurrentValue { get => (int)GetValue(RectifierCurrentValueProperty); set => SetValue(RectifierCurrentValueProperty, value); }

        //#endregion
        //#region RectifierCurrentValueBrush : Brush - Цвет значения тока

        ///// <summary>Цвет значения тока</summary>
        //public static readonly DependencyProperty RectifierCurrentValueBrushProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierCurrentValueBrush),
        //        typeof(Brush),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(Brush)));

        ///// <summary>Цвет значения тока</summary>
        //public Brush RectifierCurrentValueBrush { get => (Brush)GetValue(RectifierCurrentValueBrushProperty); set => SetValue(RectifierCurrentValueBrushProperty, value); }

        //#endregion
        //#region RectifierCurrentNameBrush : Brush - Цвет значения тока

        ///// <summary>Цвет значения тока</summary>
        //public static readonly DependencyProperty RectifierCurrentNameBrushProperty =
        //    DependencyProperty.Register(
        //        nameof(RectifierCurrentNameBrush),
        //        typeof(Brush),
        //        typeof(RectifierTest),
        //        new PropertyMetadata(default(Brush)));

        ///// <summary>Цвет значения тока</summary>
        //public Brush RectifierCurrentNameBrush { get => (Brush)GetValue(RectifierCurrentNameBrushProperty); set => SetValue(RectifierCurrentNameBrushProperty, value); }

        //#endregion


        #region RectifierBranchBrush : Brush - Цвет линий отвода

        /// <summary>Цвет линий отвода</summary>
        public static readonly DependencyProperty RectifierBranchBrushProperty =
            DependencyProperty.Register(
                nameof(RectifierBranchBrush),
                typeof(Brush),
                typeof(RectifierTest),
                new PropertyMetadata(default(Brush)));

        /// <summary>Цвет линий отвода</summary>
        public Brush RectifierBranchBrush { get => (Brush)GetValue(RectifierBranchBrushProperty); set => SetValue(RectifierBranchBrushProperty, value); }

        #endregion
        #region RectifierBrush : Brush - Цвет основного блока и подвода

        /// <summary>Цвет основного блока и подвода</summary>
        public static readonly DependencyProperty RectifierBrushProperty =
            DependencyProperty.Register(
                nameof(RectifierBrush),
                typeof(Brush),
                typeof(RectifierTest),
                new PropertyMetadata(default(Brush)));

        /// <summary>Цвет основного блока и подвода</summary>
        public Brush RectifierBrush { get => (Brush)GetValue(RectifierBrushProperty); set => SetValue(RectifierBrushProperty, value); }

        #endregion

        #region IsFault : bool - Неисправность устройства

        /// <summary>Неисправность устройства</summary>
        public static readonly DependencyProperty IsFaultProperty =
            DependencyProperty.Register(
                nameof(IsFault),
                typeof(bool),
                typeof(RectifierTest),
                new PropertyMetadata(default(bool)));

        /// <summary>Неисправность устройства</summary>
        public bool IsFault { get => (bool)GetValue(IsFaultProperty); set => SetValue(IsFaultProperty, value); }

        #endregion

        #region Powered : bool - Подаётся ли питание

        /// <summary>Подаётся ли питание</summary>
        public static readonly DependencyProperty PoweredProperty =
            DependencyProperty.Register(
                nameof(Powered),
                typeof(bool),
                typeof(RectifierTest),
                new PropertyMetadata(default(bool)));

        /// <summary>Подаётся ли питание</summary>
        public bool Powered { get => (bool)GetValue(PoweredProperty); set => SetValue(PoweredProperty, value); }

        #endregion

        #region ON_Left : bool - подключено слева

        /// <summary>подключено слева</summary>
        public static readonly DependencyProperty ON_LeftProperty =
            DependencyProperty.Register(
                nameof(ON_Left),
                typeof(bool),
                typeof(RectifierTest),
                new PropertyMetadata(default(bool)));

        /// <summary>подключено слева</summary>
        public bool ON_Left{ get => (bool)GetValue(ON_LeftProperty); set => SetValue(ON_LeftProperty, value); }

        #endregion

        #region ON_Right : bool - подключено справа

        /// <summary>подключено справа</summary>
        public static readonly DependencyProperty ON_RightProperty =
            DependencyProperty.Register(
                nameof(ON_Right),
                typeof(bool),
                typeof(RectifierTest),
                new PropertyMetadata(default(bool)));

        /// <summary>подключено справа</summary>
        public bool ON_Right { get => (bool)GetValue(ON_RightProperty); set => SetValue(ON_RightProperty, value); }

        #endregion

        #region ON_Central : bool - Подключено по центру

        /// <summary>Подключено по центру</summary>
        public static readonly DependencyProperty ON_CentralProperty =
            DependencyProperty.Register(
                nameof(ON_Central),
                typeof(bool),
                typeof(RectifierTest),
                new PropertyMetadata(default(bool)));

        /// <summary>Подключено по центру</summary>
        public bool ON_Central { get => (bool)GetValue(ON_CentralProperty); set => SetValue(ON_CentralProperty, value); }

        #endregion



    }
}
