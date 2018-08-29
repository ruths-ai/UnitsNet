﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToLiquidVolume
{
    public static class NumberToLiquidVolumeExtensions
    {
        #region CubicMeter

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume CubicMeters(this int value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? CubicMeters(this int? value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume CubicMeters(this long value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? CubicMeters(this long? value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume CubicMeters(this double value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? CubicMeters(this double? value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume CubicMeters(this float value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? CubicMeters(this float? value) => LiquidVolume.FromCubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume CubicMeters(this decimal value) => LiquidVolume.FromCubicMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="LiquidVolume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? CubicMeters(this decimal? value) => LiquidVolume.FromCubicMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region HectocubicMeter

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume HectocubicMeters(this int value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? HectocubicMeters(this int? value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume HectocubicMeters(this long value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? HectocubicMeters(this long? value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume HectocubicMeters(this double value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? HectocubicMeters(this double? value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume HectocubicMeters(this float value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? HectocubicMeters(this float? value) => LiquidVolume.FromHectocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume HectocubicMeters(this decimal value) => LiquidVolume.FromHectocubicMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="LiquidVolume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? HectocubicMeters(this decimal? value) => LiquidVolume.FromHectocubicMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilocubicMeter

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume KilocubicMeters(this int value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? KilocubicMeters(this int? value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume KilocubicMeters(this long value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? KilocubicMeters(this long? value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume KilocubicMeters(this double value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? KilocubicMeters(this double? value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume KilocubicMeters(this float value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? KilocubicMeters(this float? value) => LiquidVolume.FromKilocubicMeters(value);

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume KilocubicMeters(this decimal value) => LiquidVolume.FromKilocubicMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="LiquidVolume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static LiquidVolume? KilocubicMeters(this decimal? value) => LiquidVolume.FromKilocubicMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region OilBarrel

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume OilBarrels(this int value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume? OilBarrels(this int? value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume OilBarrels(this long value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume? OilBarrels(this long? value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume OilBarrels(this double value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume? OilBarrels(this double? value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume OilBarrels(this float value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume? OilBarrels(this float? value) => LiquidVolume.FromOilBarrels(value);

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume OilBarrels(this decimal value) => LiquidVolume.FromOilBarrels(Convert.ToDouble(value));

        /// <inheritdoc cref="LiquidVolume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static LiquidVolume? OilBarrels(this decimal? value) => LiquidVolume.FromOilBarrels(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
