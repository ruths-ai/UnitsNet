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
namespace UnitsNet.Extensions.NumberToGasRate
{
    public static class NumberToGasRateExtensions
    {
        #region BillionCubicFootPerDay

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate BillionCubicFeetPerDay(this int value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? BillionCubicFeetPerDay(this int? value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate BillionCubicFeetPerDay(this long value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? BillionCubicFeetPerDay(this long? value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate BillionCubicFeetPerDay(this double value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? BillionCubicFeetPerDay(this double? value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate BillionCubicFeetPerDay(this float value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? BillionCubicFeetPerDay(this float? value) => GasRate.FromBillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate BillionCubicFeetPerDay(this decimal value) => GasRate.FromBillionCubicFeetPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromBillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? BillionCubicFeetPerDay(this decimal? value) => GasRate.FromBillionCubicFeetPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicFootPerDay

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicFeetPerDay(this int value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicFeetPerDay(this int? value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicFeetPerDay(this long value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicFeetPerDay(this long? value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicFeetPerDay(this double value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicFeetPerDay(this double? value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicFeetPerDay(this float value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicFeetPerDay(this float? value) => GasRate.FromCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicFeetPerDay(this decimal value) => GasRate.FromCubicFeetPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicFeetPerDay(this decimal? value) => GasRate.FromCubicFeetPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicKiloMetersPerDay

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicKiloMetersPerDay(this int value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicKiloMetersPerDay(this int? value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicKiloMetersPerDay(this long value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicKiloMetersPerDay(this long? value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicKiloMetersPerDay(this double value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicKiloMetersPerDay(this double? value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicKiloMetersPerDay(this float value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicKiloMetersPerDay(this float? value) => GasRate.FromCubicKiloMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicKiloMetersPerDay(this decimal value) => GasRate.FromCubicKiloMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromCubicKiloMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicKiloMetersPerDay(this decimal? value) => GasRate.FromCubicKiloMetersPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMeterPerDay

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicMetersPerDay(this int value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicMetersPerDay(this int? value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicMetersPerDay(this long value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicMetersPerDay(this long? value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicMetersPerDay(this double value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicMetersPerDay(this double? value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicMetersPerDay(this float value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicMetersPerDay(this float? value) => GasRate.FromCubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate CubicMetersPerDay(this decimal value) => GasRate.FromCubicMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? CubicMetersPerDay(this decimal? value) => GasRate.FromCubicMetersPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region HectocubicMeterPerDay

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate HectocubicMetersPerDay(this int value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? HectocubicMetersPerDay(this int? value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate HectocubicMetersPerDay(this long value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? HectocubicMetersPerDay(this long? value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate HectocubicMetersPerDay(this double value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? HectocubicMetersPerDay(this double? value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate HectocubicMetersPerDay(this float value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? HectocubicMetersPerDay(this float? value) => GasRate.FromHectocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate HectocubicMetersPerDay(this decimal value) => GasRate.FromHectocubicMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromHectocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? HectocubicMetersPerDay(this decimal? value) => GasRate.FromHectocubicMetersPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilocubicMeterPerDay

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate KilocubicMetersPerDay(this int value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? KilocubicMetersPerDay(this int? value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate KilocubicMetersPerDay(this long value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? KilocubicMetersPerDay(this long? value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate KilocubicMetersPerDay(this double value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? KilocubicMetersPerDay(this double? value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate KilocubicMetersPerDay(this float value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? KilocubicMetersPerDay(this float? value) => GasRate.FromKilocubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate KilocubicMetersPerDay(this decimal value) => GasRate.FromKilocubicMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromKilocubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? KilocubicMetersPerDay(this decimal? value) => GasRate.FromKilocubicMetersPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegacubicMeterPerDay

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MegacubicMetersPerDay(this int value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MegacubicMetersPerDay(this int? value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MegacubicMetersPerDay(this long value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MegacubicMetersPerDay(this long? value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MegacubicMetersPerDay(this double value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MegacubicMetersPerDay(this double? value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MegacubicMetersPerDay(this float value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MegacubicMetersPerDay(this float? value) => GasRate.FromMegacubicMetersPerDay(value);

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MegacubicMetersPerDay(this decimal value) => GasRate.FromMegacubicMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromMegacubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MegacubicMetersPerDay(this decimal? value) => GasRate.FromMegacubicMetersPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillionCubicFootPerDay

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MillionCubicFeetPerDay(this int value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MillionCubicFeetPerDay(this int? value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MillionCubicFeetPerDay(this long value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MillionCubicFeetPerDay(this long? value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MillionCubicFeetPerDay(this double value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MillionCubicFeetPerDay(this double? value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MillionCubicFeetPerDay(this float value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MillionCubicFeetPerDay(this float? value) => GasRate.FromMillionCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate MillionCubicFeetPerDay(this decimal value) => GasRate.FromMillionCubicFeetPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromMillionCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? MillionCubicFeetPerDay(this decimal? value) => GasRate.FromMillionCubicFeetPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ThousandCubicFootPerDay

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate ThousandCubicFeetPerDay(this int value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? ThousandCubicFeetPerDay(this int? value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate ThousandCubicFeetPerDay(this long value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? ThousandCubicFeetPerDay(this long? value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate ThousandCubicFeetPerDay(this double value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? ThousandCubicFeetPerDay(this double? value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate ThousandCubicFeetPerDay(this float value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? ThousandCubicFeetPerDay(this float? value) => GasRate.FromThousandCubicFeetPerDay(value);

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate ThousandCubicFeetPerDay(this decimal value) => GasRate.FromThousandCubicFeetPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="GasRate.FromThousandCubicFeetPerDay(UnitsNet.QuantityValue)" />
        public static GasRate? ThousandCubicFeetPerDay(this decimal? value) => GasRate.FromThousandCubicFeetPerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
