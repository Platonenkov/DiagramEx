using System.Windows;
using System.Windows.Controls;

using DiagramEx.Enums.Electrical;

namespace DiagramEx.Components
{
    /// <summary>
    /// Логика взаимодействия для Generator.xaml
    /// </summary>
    public partial class Generator : UserControl
    {
        public Generator()
        {
            InitializeComponent();
        }

        #region GeneratorTypeIsCircle : bool - Тип генератора - круг или квадрат

        /// <summary>Тип генератора - круг или квадрат</summary>
        public static readonly DependencyProperty GeneratorTypeIsCircleProperty =
            DependencyProperty.Register(
                nameof(GeneratorTypeIsCircle),
                typeof(bool),
                typeof(Generator),
                new PropertyMetadata(true));

        /// <summary>Тип генератора - круг или квадрат</summary>
        public bool GeneratorTypeIsCircle { get => (bool)GetValue(GeneratorTypeIsCircleProperty); set => SetValue(GeneratorTypeIsCircleProperty, value); }

        #endregion
        #region ElectricalPathThickness : double - Толщина

        /// <summary>Толщина</summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register(
                nameof(Thickness),
                typeof(double),
                typeof(Generator),
                new PropertyMetadata(1D));

        /// <summary>Толщина</summary>
        public double Thickness { get => (double)GetValue(ThicknessProperty); set => SetValue(ThicknessProperty, value); }

        #endregion

        #region IconVisibility : Visibility - Видимость иконки-символа генератора

        /// <summary>Видимость иконки-символа генератора</summary>
        public static readonly DependencyProperty IconVisibilityProperty =
            DependencyProperty.Register(
                nameof(IconVisibility),
                typeof(Visibility),
                typeof(Generator),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость иконки-символа генератора</summary>
        public Visibility IconVisibility { get => (Visibility)GetValue(IconVisibilityProperty); set => SetValue(IconVisibilityProperty, value); }

        #endregion
        #region VOLTVisibility : Visibility - Видимость напряжения генератора

        /// <summary>Видимость напряжения генератора</summary>
        public static readonly DependencyProperty VOLTVisibilityProperty =
            DependencyProperty.Register(
                nameof(VOLTVisibility),
                typeof(Visibility),
                typeof(Generator),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость напряжения генератора</summary>
        public Visibility VOLTVisibility { get => (Visibility)GetValue(VOLTVisibilityProperty); set => SetValue(VOLTVisibilityProperty, value); }

        #endregion
        #region LOADVisibility : Visibility - Видимость загрузки генератора

        /// <summary>Видимость загрузки генератора</summary>
        public static readonly DependencyProperty LOADVisibilityProperty =
            DependencyProperty.Register(
                nameof(LOADVisibility),
                typeof(Visibility),
                typeof(Generator),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость загрузки генератора</summary>
        public Visibility LOADVisibility { get => (Visibility)GetValue(LOADVisibilityProperty); set => SetValue(LOADVisibilityProperty, value); }

        #endregion
        #region FREQVisibility : Visibility - Видимость частоты генератора

        /// <summary>Видимость частоты генератора</summary>
        public static readonly DependencyProperty FREQVisibilityProperty =
            DependencyProperty.Register(
                nameof(FREQVisibility),
                typeof(Visibility),
                typeof(Generator),
                new PropertyMetadata(Visibility.Visible));

        /// <summary>Видимость частоты генератора</summary>
        public Visibility FREQVisibility { get => (Visibility)GetValue(FREQVisibilityProperty); set => SetValue(FREQVisibilityProperty, value); }

        #endregion

        #region GeneratorNameWidth : double - Размер поля имени генератора

        /// <summary>Размер поля имени генератора</summary>
        public static readonly DependencyProperty GeneratorNameWidthProperty =
            DependencyProperty.Register(
                nameof(GeneratorNameWidth),
                typeof(double),
                typeof(Generator),
                new PropertyMetadata(default(double)));

        /// <summary>Размер поля имени генератора</summary>
        public double GeneratorNameWidth { get => (double)GetValue(GeneratorNameWidthProperty); set => SetValue(GeneratorNameWidthProperty, value); }

        #endregion
        #region GeneratorNameAlign : TextAlignment - Выравнивание текста имени

        /// <summary>Выравнивание текста имени</summary>
        public static readonly DependencyProperty GeneratorNameAlignProperty =
            DependencyProperty.Register(
                nameof(GeneratorNameAlign),
                typeof(TextAlignment),
                typeof(Generator),
                new PropertyMetadata(default(TextAlignment)));

        /// <summary>Выравнивание текста имени</summary>
        public TextAlignment GeneratorNameAlign { get => (TextAlignment)GetValue(GeneratorNameAlignProperty); set => SetValue(GeneratorNameAlignProperty, value); }

        #endregion
        #region GeneratorNameHorAlign : HorizontalAlignment - Горизонтальное выравнивание поля имени

        /// <summary>Горизонтальное выравнивание поля имени</summary>
        public static readonly DependencyProperty GeneratorNameHorAlignProperty =
            DependencyProperty.Register(
                nameof(GeneratorNameHorAlign),
                typeof(HorizontalAlignment),
                typeof(Generator),
                new PropertyMetadata(default(HorizontalAlignment)));

        /// <summary>Горизонтальное выравнивание поля имени</summary>
        public HorizontalAlignment GeneratorNameHorAlign { get => (HorizontalAlignment)GetValue(GeneratorNameHorAlignProperty); set => SetValue(GeneratorNameHorAlignProperty, value); }

        #endregion
        #region GeneratorNameVerAlign : VerticalAlignment - Вертикальное выравнивание поля имени

        /// <summary>Горизонтальное выравнивание поля имени</summary>
        public static readonly DependencyProperty GeneratorNameVerAlignProperty =
            DependencyProperty.Register(
                nameof(GeneratorNameVerAlign),
                typeof(VerticalAlignment),
                typeof(Generator),
                new PropertyMetadata(default(VerticalAlignment)));

        /// <summary>Горизонтальное выравнивание поля имени</summary>
        public VerticalAlignment GeneratorNameVerAlign { get => (VerticalAlignment)GetValue(GeneratorNameVerAlignProperty); set => SetValue(GeneratorNameVerAlignProperty, value); }

        #endregion
        #region GeneratorName : string - название генератора

        /// <summary>название генератора</summary>
        public static readonly DependencyProperty GeneratorNameProperty =
            DependencyProperty.Register(
                nameof(GeneratorName),
                typeof(string),
                typeof(Generator),
                new PropertyMetadata(default(string)));

        /// <summary>название генератора</summary>
        public string GeneratorName { get => (string)GetValue(GeneratorNameProperty); set => SetValue(GeneratorNameProperty, value); }

        #endregion
        #region GeneratorNamePosition : Dock - Позиция расположения имени

        /// <summary>Позиция расположения имени</summary>
        public static readonly DependencyProperty GeneratorNamePositionProperty =
            DependencyProperty.Register(
                nameof(GeneratorNamePosition),
                typeof(Dock),
                typeof(Generator),
                new PropertyMetadata(Dock.Bottom));

        /// <summary>Позиция расположения имени</summary>
        public Dock GeneratorNamePosition { get => (Dock)GetValue(GeneratorNamePositionProperty); set => SetValue(GeneratorNamePositionProperty, value); }

        #endregion

        #region GEN_IND : GeneratorStatus - Индикация генератора

        /// <summary>Индикация генератора</summary>
        public static readonly DependencyProperty GEN_INDProperty =
            DependencyProperty.Register(
                nameof(GEN_IND),
                typeof(GeneratorStatus),
                typeof(Generator),
                new PropertyMetadata(default(GeneratorStatus)));

        /// <summary>Индикация генератора</summary>
        public GeneratorStatus GEN_IND { get => (GeneratorStatus)GetValue(GEN_INDProperty); set => SetValue(GEN_INDProperty, value); }

        #endregion
        #region IDG_VOLT : double - Напряжение генератора

        /// <summary>Напряжение генератора</summary>
        public static readonly DependencyProperty IDG_VOLTProperty =
            DependencyProperty.Register(
                nameof(IDG_VOLT),
                typeof(double),
                typeof(Generator),
                new PropertyMetadata(default(double)));

        /// <summary>Напряжение генератора</summary>
        public double IDG_VOLT { get => (double)GetValue(IDG_VOLTProperty); set => SetValue(IDG_VOLTProperty, value); }

        #endregion
        #region IDG_LOAD : double - Нагрузка генератора

        /// <summary>Нагрузка генератора</summary>
        public static readonly DependencyProperty IDG_LOADProperty =
            DependencyProperty.Register(
                nameof(IDG_LOAD),
                typeof(double),
                typeof(Generator),
                new PropertyMetadata(default(double)));

        /// <summary>Нагрузка генератора</summary>
        public double IDG_LOAD { get => (double)GetValue(IDG_LOADProperty); set => SetValue(IDG_LOADProperty, value); }

        #endregion
        #region IDG_FREQ : double - Выходная частота генератора

        /// <summary>Выходная частота генератора</summary>
        public static readonly DependencyProperty IDG_FREQProperty =
            DependencyProperty.Register(
                nameof(IDG_FREQ),
                typeof(double),
                typeof(Generator),
                new PropertyMetadata(default(double)));

        /// <summary>Выходная частота генератора</summary>
        public double IDG_FREQ { get => (double)GetValue(IDG_FREQProperty); set => SetValue(IDG_FREQProperty, value); }

        #endregion
        #region GeneratorParametersPosition : ParameterPositionEnum - Позиция расположения параметров генератора (напряжение, загрузка, частота)

        /// <summary>Позиция расположения параметров генератора (напряжение, загрузка, частота)</summary>
        public static readonly DependencyProperty GeneratorParametersPositionProperty =
            DependencyProperty.Register(
                nameof(GeneratorParametersPosition),
                typeof(ParameterPositionEnum),
                typeof(Generator),
                new PropertyMetadata(ParameterPositionEnum.Left));

        /// <summary>Позиция расположения параметров генератора (напряжение, загрузка, частота)</summary>
        public ParameterPositionEnum GeneratorParametersPosition { get => (ParameterPositionEnum)GetValue(GeneratorParametersPositionProperty); set => SetValue(GeneratorParametersPositionProperty, value); }

        #endregion
    }
}
