using System.Diagnostics.CodeAnalysis;
using DST = System.Diagnostics.DebuggerStepThroughAttribute;
// ReSharper disable UnusedMember.Global

// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable once CheckNamespace
namespace System
{
    /// <summary>Расширения для чисел двойной точности</summary>
    internal static class DoubleExtensions
    {
        public static bool EqualWithAccuracy(this double x, double y, double Accuracy = 1.1102230246251565E-15) => x.Check(y, x - y, Accuracy);

        private static bool Check(this double x, double y, double delta, double Accuracy = 1.1102230246251565E-15)
        {
            if (double.IsInfinity(x) || double.IsInfinity(y)) return x.Equals(y);
            if (double.IsNaN(x) || double.IsNaN(y)) return false;
            return Math.Abs(delta) < Math.Abs(Accuracy);
        }

        /// <summary>Модуль числа</summary>
        /// <param name="x">Действительное вещественное число</param>
        /// <returns>Модуль числа</returns>
        [DST] public static double Abs(this double x) => double.IsNaN(x) ? double.NaN : Math.Abs(x);
        [DST] public static float Abs(this float x) => float.IsNaN(x) ? float.NaN : Math.Abs(x);
        [DST] public static decimal Abs(this decimal x) => Math.Abs(x);

        [DST] public static int Abs(this int x) => Math.Abs(x);
        [DST] public static long Abs(this long x) => Math.Abs(x);
        [DST] public static short Abs(this short x) => Math.Abs(x);
        [DST] public static sbyte Abs(this sbyte x) => Math.Abs(x);

        /// <summary>Число по модулю</summary>
        /// <param name="x">Исходное число</param>
        /// <param name="mod">Модуль</param>
        /// <returns>Число по модулю</returns>
        [DST] public static double AbsMod(this double x, double mod) => x % mod + (x < 0 ? mod : 0);


        [DST] public static double Sign(this double x) => double.IsNaN(x) ? double.NaN : Math.Sign(x);
        [DST] public static double Round(this double x) => double.IsNaN(x) ? double.NaN : Math.Round(x);
        [DST] public static double Floor(this double x) => double.IsNaN(x) ? double.NaN : Math.Floor(x);
        [DST] public static double Truncate(this double x) => double.IsNaN(x) ? double.NaN : Math.Truncate(x);
        [DST] public static double Ceiling(this double x) => double.IsNaN(x) ? double.NaN : Math.Ceiling(x);

        [DST] public static float Sign(this float x) => float.IsNaN(x) ? float.NaN : Math.Sign(x);
        [DST] public static float Round(this float x) => float.IsNaN(x) ? float.NaN : (float)Math.Round(x);
        [DST] public static float Floor(this float x) => float.IsNaN(x) ? float.NaN : (float)Math.Floor(x);
        [DST] public static float Truncate(this float x) => float.IsNaN(x) ? float.NaN : (float)Math.Truncate(x);
        [DST] public static float Ceiling(this float x) => float.IsNaN(x) ? float.NaN : (float)Math.Ceiling(x);

        [DST]
        public static int Pow(this int x, int p)
        {
            switch (p)
            {
                case < 0: return 1 / x.Pow(-p);
                case 0: return 1;
                case 1: return x;
                case 2: return x * x;
                case 3: return x * x * x;
                case 4: return x * x * x * x;
                default:
                    var result = x;
                    for (var i = 1; i < p; i++)
                        result *= x;
                    return result;
            }
        }

        [DST]
        public static double Pow(this double x, int p)
        {
            if (x is double.NaN) return double.NaN;
            switch (p)
            {
                case < 0: return 1 / x.Pow(-p);
                case 0: return 1;
                case 1: return x;
                case 2: return x * x;
                case 3: return x * x * x;
                case 4: return x * x * x * x;
                default:
                    var result = x;
                    for (var i = 1; i < p; i++)
                        result *= x;
                    return result;
            }
        }

        [DST] public static double Pow(this double x, double p) => double.IsNaN(x) ? double.NaN : double.IsNaN(p) ? double.NaN : Math.Pow(x, p);

        [DST] public static double Pow2(this double x) => x * x;
        [DST] public static float Pow2(this float x) => x * x;
        [DST] public static int Pow2(this int value) => value * value;
        [DST] public static uint Pow2(this uint value) => value * value;
        [DST] public static long Pow2(this long value) => value * value;
        [DST] public static ulong Pow2(this ulong value) => value * value;
        [DST] public static short Pow2(this short value) => (short)(value * value);
        [DST] public static ushort Pow2(this ushort value) => (ushort)(value * value);
        [DST] public static byte Pow2(this byte value) => (byte)(value * value);
        [DST] public static byte Pow2(this sbyte value) => (byte)(value * value);

        /// <summary>Квадратный корень</summary>
        /// <param name="x">Число из которого извлекается квадратный корень</param>
        /// <returns>Квадратный корень числа</returns>
        [DST] public static double Sqrt(this double x) => double.IsNaN(x) ? double.NaN : Math.Sqrt(x);

        /// <summary>Квадратный корень</summary>
        /// <param name="x">Число из которого извлекается квадратный корень</param>
        /// <returns>Квадратный корень числа</returns>
        [DST] public static float Sqrt(this float x) => float.IsNaN(x) ? float.NaN : (float)Math.Sqrt(x);

        /// <summary>Является ли число целым?</summary>
        /// <param name="x">Проверяемое число</param>
        /// <returns>Истина, если число целое</returns>
        [DST] public static bool IsInt(this double x) => !double.IsNaN(x) && ((int)x - x).Equals(0d);

        /// <summary>Является ли число целым?</summary>
        /// <param name="x">Проверяемое число</param>
        /// <returns>Истина, если число целое</returns>
        [DST] public static bool IsInt(this float x) => !float.IsNaN(x) && ((int)x - x).Equals(0f);

        /// <summary>Является ли значение "не числом"?</summary>
        /// <param name="x">Проверяемое значение</param>
        /// <returns>Истина, если значение - не число</returns>
        [DST] public static bool IsNaN(this double x) => double.IsNaN(x);

        /// <summary>Является ли значение "не числом"?</summary>
        /// <param name="x">Проверяемое значение</param>
        /// <returns>Истина, если значение - не число</returns>
        [DST] public static bool IsNaN(this float x) => float.IsNaN(x);

        /// <summary>Округление числа до указанного количества знаков после запятой </summary>
        /// <param name="x">Округляемое число</param>
        /// <param name="n">Количество знаков после запятой при n >= 0 и до запятой при n меньше 0</param>
        /// <returns>Число, округлённое до указанной точности</returns>
        [DST]
        public static double Round(this double x, int n)
        {
            if (double.IsNaN(x)) return x;
            if (n >= 0) return Math.Round(x, n);

            var nn = -n;
            var b = Math.Pow(10, nn);
            return Math.Round(x / b) * b;
        }

        /// <summary>Округление числа до указанного количества знаков после запятой </summary>
        /// <param name="x">Округляемое число</param>
        /// <param name="n">Количество знаков после запятой при n >= 0 и до запятой при n меньше 0</param>
        /// <returns>Число, округлённое до указанной точности</returns>
        [DST]
        public static float Round(this float x, int n)
        {
            if (float.IsNaN(x)) return x;
            if (n >= 0) return (float)Math.Round(x, n);

            var nn = -n;
            var b = Math.Pow(10, nn);
            return (float)(Math.Round(x / b) * b);
        }

        //[DST] public static Vector3D RoundAdaptive(this Vector3D r, int n = 1) => new Vector3D(r.X.RoundAdaptive(n), r.Y.RoundAdaptive(n), r.Z.RoundAdaptive(n));


        /// <summary>Адаптивное округление</summary>
        /// <param name="x">Округляемая величина</param>
        /// <param name="n">Количество значащих разрядов</param>
        /// <returns>Число с указанным количеством значащих разрядов</returns>
        [DST]
        public static double RoundAdaptive(this double x, int n = 1)
        {
            if (x.Equals(0d)) return 0;
            if (double.IsNaN(x)) return x;
            if (double.IsInfinity(x)) return x;
            var sign = Math.Sign(x);
            x = x.Abs();
            var b = Math.Pow(10, (int)Math.Log10(x) - 1);
            return Math.Round(x / b, n - 1) * b * sign;
        }

        /// <summary>Адаптивное округление</summary>
        /// <param name="x">Округляемая величина</param>
        /// <param name="n">Количество значащих разрядов</param>
        /// <returns>Число с указанным количеством значащих разрядов</returns>
        [DST]
        public static float RoundAdaptive(this float x, int n = 1)
        {
            if (x.Equals(0f)) return 0;
            if (float.IsNaN(x)) return x;
            if (float.IsInfinity(x)) return x;
            var sign = Math.Sign(x);
            x = x.Abs();
            var b = Math.Pow(10, (int)Math.Log10(x) - 1);
            return (float)(Math.Round(x / b, n - 1) * b * sign);
        }

        /// <summary>Получить обратное число</summary>
        /// <param name="x">Инвертируемое число</param>
        /// <returns>Число, обратное к исходном</returns>
        [DST] public static double GetInverse(this double x) => 1 / x;

        /// <summary>Получить обратное число</summary>
        /// <param name="x">Инвертируемое число</param>
        /// <returns>Число, обратное к исходном</returns>
        [DST] public static float GetInverse(this float x) => 1 / x;

        /// <summary>Возведение в целую степень</summary>
        /// <param name="x">Действительное число</param>
        /// <param name="n">Целочисленный показатель степени</param>
        /// <returns>x^n</returns>
        [DST]
        public static double Power(this double x, int n)
        {
            if (double.IsNaN(x)) return double.NaN;
            if (x.Equals(0d)) return 0d;
            if (x.Equals(1d)) return 1d;
            if (n > 1000 || n < -1000) return Math.Pow(x, n);
            if (n < 0) return (1 / x).Power(-n);
            var result = 1.0;
            for (var i = 0; i < n; i++)
                result *= x;
            return result;
        }

        /// <summary>Возведение в целую степень</summary>
        /// <param name="x">Действительное число</param>
        /// <param name="n">Целочисленный показатель степени</param>
        /// <returns>x^n</returns>
        [DST]
        public static float Power(this float x, int n)
        {
            if (float.IsNaN(x)) return float.NaN;
            if (x.Equals(0f)) return 0f;
            if (x.Equals(1f)) return 1f;
            if (n > 1000 || n < -1000) return (float)Math.Pow(x, n);
            if (n < 0) return (1 / x).Power(-n);
            var result = 1.0;
            for (var i = 0; i < n; i++)
                result *= x;
            return (float)result;
        }

        /// <summary>Возведение числа в действительную степень</summary>
        /// <param name="x">Основание</param><param name="y">Действительный показатель степени</param>
        /// <returns>Действительное число x возведённое в степень y: x^y</returns>
        [DST] public static double Power(this double x, double y) => double.IsNaN(x) ? double.NaN : (double.IsNaN(y) ? double.NaN : Math.Pow(x, y));

        /// <summary>Возведение числа в действительную степень</summary>
        /// <param name="x">Основание</param><param name="y">Действительный показатель степени</param>
        /// <returns>Действительное число x возведённое в степень y: x^y</returns>
        [DST] public static float Power(this float x, float y) => float.IsNaN(x) ? float.NaN : (float.IsNaN(y) ? float.NaN : (float)Math.Pow(x, y));

        /// <summary>Преобразование в децибелы по амплитуде</summary>
        /// <param name="x">Амплитудное значение 20*lg(x)</param>
        /// <returns>Значение в децибелах</returns>
        [DST] public static double In_dB(this double x) => double.IsNaN(x) ? double.NaN : 20 * Math.Log10(x);

        /// <summary>Преобразование в децибелы по мощности</summary>
        /// <param name="x">Значение мощности 10*lg(x)</param>
        /// <returns>Значение в децибелах</returns>
        [DST] public static double In_dB_byPower(this double x) => double.IsNaN(x) ? double.NaN : 10 * Math.Log10(x);

        /// <summary>Преобразование из децибелов в разы по значению (амплитуде)</summary>
        /// <param name="db">Значение в децибелах 10^(x/20)</param>
        /// <returns>Значение в разах по амплитуде</returns>
        [DST] public static double From_dB(this double db) => double.IsNaN(db) ? double.NaN : Math.Pow(10, db / 20);

        /// <summary>Преобразование из децибелов в разы по мощности</summary>
        /// <param name="db">Значение в децибелах 10^(x/10)</param>
        /// <returns>Значение в разах по мощности</returns>
        [DST] public static double From_dB_byPower(this double db) => double.IsNaN(db) ? double.NaN : Math.Pow(10, db / 10);

        /// <summary>Преобразование значения в радианы</summary>
        /// <param name="deg">Значение в градусах</param>
        /// <returns>Значение в радианах</returns>
        [DST] public static double ToRad(this double deg) => deg * Consts.Geometry.ToRad;

        /// <summary>Преобразование значения в градусы</summary>
        /// <param name="rad">Значение в радианах</param>
        /// <returns>Значение в градусах</returns>
        [DST] public static double ToDeg(this double rad) => rad * Consts.Geometry.ToDeg;

        /// <summary>Преобразование значения в радианы</summary>
        /// <param name="deg">Значение в градусах</param>
        /// <returns>Значение в радианах</returns>
        [DST] public static float ToRad(this float deg) => (float)(deg * Consts.Geometry.ToRad);

        /// <summary>Преобразование значения в градусы</summary>
        /// <param name="rad">Значение в радианах</param>
        /// <returns>Значение в градусах</returns>
        [DST] public static float ToDeg(this float rad) => (float)(rad * Consts.Geometry.ToDeg);

        public static long ToIntBits(this double x) => BitConverter.DoubleToInt64Bits(x);
        public static double ToDoubleBits(this long x) => BitConverter.Int64BitsToDouble(x);
    }
    /// <summary>Константы</summary>
    internal static class Consts
    {
        /// <summary>% = 0.01</summary>
        public const double Percent = 0.01;

        /// <summary>e = 2.7182818284590452353602874713527</summary>
        public const double e = 2.7182818284590452353602874713526624977572470937000d;

        /// <summary>π/16 (90°/8 = 11.25°)</summary>
        public const double pi00625 = .5 * pi0125;
        /// <summary>π/8 (90/4° = 22.5°)</summary>
        public const double pi0125 = .5 * pi025;
        /// <summary>π/4 (90°/2 = 45°)</summary>
        public const double pi025 = 0.78539816339744830961566084581987572104929234984378d;

        /// <summary>π/2 (90°)</summary>
        public const double pi05 = 1.5707963267948966192313216916397514420985846996876d;
        /// <summary>-π/2 (-90°)</summary>
        public const double pi05neg = -1.5707963267948966192313216916397514420985846996876d;

        /// <summary>π = 3.1415926535897932384626433832795028841971693993751</summary>
        public const double pi = 3.1415926535897932384626433832795028841971693993751d;
        /// <summary>-π = -3.1415926535897932384626433832795028841971693993751</summary>
        public const double pi_neg = -3.1415926535897932384626433832795028841971693993751d;
        /// <summary>2·π (360°)</summary>
        public const double pi2 = 6.2831853071795864769252867665590057683943387987502d;
        /// <summary>-2·π (-360°)</summary>
        public const double pi2neg = -6.2831853071795864769252867665590057683943387987502d;
        /// <summary>3·π/2</summary>
        public const double pi3_2 = 4.71238898038468985769396507491925432629575409906266d;

        /// <summary>Ln_e(pi)</summary>
        public const double LnPi = 1.1447298858494001741434273513530587116472948129153d;
        /// <summary>Ln_e(2pi)</summary>
        public const double Ln2Pi = 0.91893853320467274178032973640561763986139747363780d;

        /// <summary>ln(2√(e/π))</summary>
        public const double Ln2Sqrt_e_div_pi = 0.6207822376352452223455184457816472122518527279025978;

        /// <summary>π/180</summary>
        public const double ToRad = pi / 180d;
        /// <summary>180/π</summary>
        public const double ToDeg = 180d / pi;

        /// <summary>'π'</summary>
        public const string pi_name = "π";
        /// <summary>'°'</summary>
        public const string deg_name = "°";

        /// <summary>√e</summary>
        public const double sqrt_e = 1.6487212707001281468486507878141635716537761007101d;
        /// <summary>√π</summary>
        public const double sqrt_pi = 2.5066282746310005024157652848110452530069867406099d;
        /// <summary>√(2·π)</summary>
        public const double sqrt_pi2 = 2.5066282746310005024157652848110452530069867406099d;
        /// <summary>√(π/2)</summary>
        public const double sqrt_pi05 = 1.2533141373155002512078826424055226265034933703050d;

        /// <summary>√2 = 1.4142135623730950488016887242096980785696718753769</summary>
        public const double sqrt_2 = 1.4142135623730950488016887242096980785696718753769d;
        /// <summary>1 / √2 = 0.707...</summary>
        public const double sqrt_2_inv = 1 / sqrt_2;

        /// <summary>√3 = 1.7320508075688772935274463415058723669428052538104</summary>
        public const double sqrt_3 = 1.7320508075688772935274463415058723669428052538104d;

        /// <summary>√5 = 2.236067...</summary>
        public const double sqrt_5 = 2.2360679774997896964091736687313;

        /// <summary>1 / √5 = 0.4472135954999579...</summary>
        public const double sqrt_5_inv = 1 / sqrt_5;

        /// <summary>Золотое сечение = (√5 + 1)/2</summary>
        public const double GoldenRatio = (sqrt_5 + 1) / 2;

        /// <summary>Величина, обратная золотому сечению = (√5 - 1)/2</summary>
        public const double GoldenRatio_Inv = 1 / GoldenRatio;

        /// <summary>Геометрические константы</summary>
        [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
        public static class Geometry
        {
            /// <summary>Константа преобразования радиан в градусы = 180/π</summary>
            public const double ToDeg = 180d / pi;
            /// <summary>Константа преобразования градусов в радианы = π/180</summary>
            public const double ToRad = 0.017453292519943295769236907684886127134428718885417d;
            /// <summary>Системная константа π = 3.1415926535897932384626433832</summary>
            public const double Pi = Math.PI;

            /// <summary>Преобразовать значение из радиан в градусы</summary>
            /// <param name="RadValue">Значение в радианах</param>
            /// <returns>Значение в градусах</returns>
            public static double ConvertToDeg(double RadValue) => RadValue * ToDeg;

            /// <summary>Преобразовать значение из градусов в радианы</summary>
            /// <param name="DegValue">Значение в градусах</param>
            /// <returns>Значение в радианах</returns>
            public static double ConvertToRad(double DegValue) => DegValue * ToRad;
        }

        /// <summary>Скорость света 300`000`000 м/с = 3e8 м/с</summary>
        public const double SpeedOfLight = 3e8;
        /// <summary>Скорость света в вакууме 299`792`458 м/с</summary>
        public const double SpeedOfLightInVacuum = 2.99792458e8;

        /// <summary>Гравитационная постоянная 6.67384(80)×10^−11 m^3·кг^−1·с^−2</summary>
        public const double GravitationConstant = 6.673848080808080808080808080E-11;

        /// <summary>Постоянная Планка 6.626 069 57(29) ×10^−34 Жд·с</summary>
        public const double PlanckConstant = 6.6260695729292929292929E-34;

        /// <summary>Приведённая постоянная Планка 1.054 571 628(53) ×10^−34 Жд·с</summary>
        public const double PlanckConstant_Reduced = PlanckConstant / (2 * pi);

        /// <summary>Температура Планка √(h_bar * c^5/G)/k K</summary>
        public const double Planck_Temperature = 1.416786e32;

        /// <summary>Длина Планка h_bar/(m_p*c) м</summary>
        public const double Planck_Length = 1.616253e-35;

        /// <summary>Время Планка lp/c с</summary>
        public const double Planck_Time = 5.39124e-44;

        /// <summary>Электродинамические константы</summary>
        public static class Electrodynamic
        {
            /// <summary>Электрическая постоянная 1/(Mu0 · c^2) = 8,854187817620… ×10^−12 Ф·м^−1</summary>
            public const double Epsilon0 = 8.8541878171937079244693661186959426889222899381429e-12;//1 / (Mu0 * SpeedOfLightInVacuum * SpeedOfLightInVacuum);

            /// <summary>Магнитная постоянная 4·π ×10^-7 = 1.2566370614E-6 Гн/м</summary>
            public const double Mu0 = 1.2566370614359172953850573533118011536788677597500e-6;

            /// <summary>Упрощённое сопротивление среды (вакуума) = √(Mu0/Epsilon0) = 377 Ом</summary>
            public const double Impedance = 377;

            /// <summary>Сопротивление среды (вакуума) = √(Mu0/Epsilon0) = 376.730313461771 Ом</summary>
            public const double Impedance0 = 376.73031346177065546819840042031930826862350835242;

            /// <summary>Преобразовать значение частоты в длину волны</summary>
            /// <param name="Frequency">Значение частоты в Гц</param>
            /// <returns>Длина волны в метрах</returns>
            public static double ToWaveLength(double Frequency) => SpeedOfLight / Frequency;

            /// <summary>Преобразовать значение частоты в длину волны с учётом диэлектрической проницаемости среды</summary>
            /// <param name="Frequency">Значение частоты в Гц</param>
            /// <param name="Epsilon">Значение относительной диэлектрической проницаемости среды</param>
            /// <returns>Значение длины волны в среде в метрах</returns>
            public static double ToWaveLength(double Frequency, double Epsilon) => SpeedOfLight / Frequency / Math.Sqrt(Epsilon);

            /// <summary>Преобразовать значение частоты в длину волны с учётом диэлектрической и магнитной проницаемости среды</summary>
            /// <param name="Frequency">Значение частоты в Гц</param>
            /// <param name="Epsilon">Значение относительной диэлектрической проницаемости среды</param>
            /// <param name="Mu">Значение магнитной проницаемости среды</param>
            /// <returns>Значение длины волны в среде в метрах</returns>
            public static double ToWaveLength(double Frequency, double Epsilon, double Mu) => SpeedOfLight / Frequency / Math.Sqrt(Epsilon / Mu);

            /// <summary>Преобразование длины волны в метрах в частоту в Гц</summary>
            /// <param name="WaveLength">Значение длины волны в метрах</param>
            /// <returns>Значение частоты в Гц</returns>
            public static double ToFrequency(double WaveLength) => SpeedOfLight / WaveLength;

            /// <summary>Преобразование длины волны в среде в метрах в частоту в Гц</summary>
            /// <param name="WaveLength">Значение длины волны в среде в метрах</param>
            /// <param name="Epsilon">Значение относительной диэлектрической проницаемости среды</param>
            /// <returns>Значение частоты в Гц</returns>
            public static double ToFrequency(double WaveLength, double Epsilon) => SpeedOfLight / WaveLength / Math.Sqrt(Epsilon);

            /// <summary>Преобразование длины волны в среде в метрах в частоту в Гц</summary>
            /// <param name="WaveLength">Значение длины волны в среде в метрах</param>
            /// <param name="Epsilon">Значение относительной диэлектрической проницаемости среды</param>
            /// <param name="Mu">Значение магнитной проницаемости среды</param>
            /// <returns>Значение частоты в Гц</returns>
            public static double ToFrequency(double WaveLength, double Epsilon, double Mu) => SpeedOfLight / WaveLength / Math.Sqrt(Epsilon / Mu);
        }

        // ReSharper disable once CommentTypo
        /// <summary>0x3ffeffff = 1073676287</summary>
        public const int BigPrime_int = 0x3ffeffff;

        /// <summary>0x3fffffefffffff = 18014398241046527</summary>
        public const long BigPrime_long = 0x3fffffefffffff;

        /// <summary>Размеры данных</summary>
        public static class DataLength
        {
            /// <summary>Размеры данных в байтах</summary>
            public static class Bytes
            {
                /// <summary>1 Байт</summary>
                public const int B = 1;
                /// <summary>1 килобайт в байтах</summary>
                public const int kB = 0x400 * B;
                /// <summary>1 мегабайт в байтах</summary>
                public const int MB = 0x400 * kB;
                /// <summary>1 гигабайт в байтах</summary>
                public const int GB = 0x400 * MB;
                /// <summary>1 терабайт в байтах</summary>
                public const long TB = 1024L * GB;

                /// <summary>Получить имена значений количества байт с приставками "B", "kB", "MB", "GB", "TB"</summary>
                /// <returns>"B", "kB", "MB", "GB", "TB"</returns>
                public static string[] GetDataNames() => new[] { "B", "kB", "MB", "GB", "TB" };

                /// <summary>Получить русскоязычные имена значений количества байт с приставками "Б", "кБ", "МБ", "ГБ", "ТБ"</summary>
                /// <returns>"Б", "кБ", "МБ", "ГБ", "ТБ"</returns>
                public static string[] GetDataNamesRu() => new[] { "Б", "кБ", "МБ", "ГБ", "ТБ" };
            }
        }

        /// <summary>Элементарный заряд e = 1,602 176 565(35)·10^−19 Кл</summary>
        public const double ElementaryCharge = 1.602176565353535353535353535353535353535e-19;

        /// <summary>Постоянная Больцмана k = 1,380 6488(13)·10^−23 Дж/К</summary>
        public const double BoltzmannConstant = 1.38064881313131313131313131313131313131313e-23;

        /// <summary>Число Авогадро Na = 6,022 141 29(27)·10^23 1/моль</summary>
        public const double AvogadroConstant = 6.02214129272727272727272727272727272727272727e23;

        /// <summary>Постоянная Фарадея F = e * Na = 96485,33(83) Кл/моль</summary>
        public const double FaradayConstant = ElementaryCharge * AvogadroConstant;
    }
}