﻿using System;
using System.Windows.Data;
using System.Windows.Markup;

// ReSharper disable PropertyCanBeMadeInitOnly.Global

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedType.Global

namespace DiagramEx.Converters
{
    [ValueConversion(typeof(double), typeof(double))]
    internal class RoundAdaptive : DoubleValueConverter
    {
        [ConstructorArgument(nameof(Digits))]
        public int Digits { get; set; }

        [ConstructorArgument(nameof(Rounding))]
        public MidpointRounding Rounding { get; set; }

        public RoundAdaptive() {}

        public RoundAdaptive(int Digits) => this.Digits = Digits;

        public RoundAdaptive(int Digits, MidpointRounding Rounding) : this(Digits) => this.Rounding = Rounding;

        /// <inheritdoc />
        protected override double Convert(double v, double? p = null) => v.RoundAdaptive(Digits);

        /// <inheritdoc />
        protected override double ConvertBack(double v, double? p = null) => v;
    }
}