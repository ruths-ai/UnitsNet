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
namespace UnitsNet.Extensions.NumberToBoeRate
{
    public static class NumberToBoeRateExtensions
    {
        #region BoePerDay

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate BoePerDay(this int value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? BoePerDay(this int? value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate BoePerDay(this long value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? BoePerDay(this long? value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate BoePerDay(this double value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? BoePerDay(this double? value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate BoePerDay(this float value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? BoePerDay(this float? value) => BoeRate.FromBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate BoePerDay(this decimal value) => BoeRate.FromBoePerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="BoeRate.FromBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? BoePerDay(this decimal? value) => BoeRate.FromBoePerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillionBoePerDay

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate MillionBoePerDay(this int value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? MillionBoePerDay(this int? value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate MillionBoePerDay(this long value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? MillionBoePerDay(this long? value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate MillionBoePerDay(this double value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? MillionBoePerDay(this double? value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate MillionBoePerDay(this float value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? MillionBoePerDay(this float? value) => BoeRate.FromMillionBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate MillionBoePerDay(this decimal value) => BoeRate.FromMillionBoePerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="BoeRate.FromMillionBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? MillionBoePerDay(this decimal? value) => BoeRate.FromMillionBoePerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ThousandBoePerDay

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate ThousandBoePerDay(this int value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? ThousandBoePerDay(this int? value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate ThousandBoePerDay(this long value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? ThousandBoePerDay(this long? value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate ThousandBoePerDay(this double value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? ThousandBoePerDay(this double? value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate ThousandBoePerDay(this float value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? ThousandBoePerDay(this float? value) => BoeRate.FromThousandBoePerDay(value);

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate ThousandBoePerDay(this decimal value) => BoeRate.FromThousandBoePerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="BoeRate.FromThousandBoePerDay(UnitsNet.QuantityValue)" />
        public static BoeRate? ThousandBoePerDay(this decimal? value) => BoeRate.FromThousandBoePerDay(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
