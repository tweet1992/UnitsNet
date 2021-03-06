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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In everyday use and in kinematics, the speed of an object is the magnitude of its velocity (the rate of change of its position); it is thus a scalar quantity.[1] The average speed of an object in an interval of time is the distance travelled by the object divided by the duration of the interval;[2] the instantaneous speed is the limit of the average speed as the duration of the time interval approaches zero.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Speed : IComparable, IComparable<Speed>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Speed from nullable CentimetersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromCentimetersPerHour(QuantityValue? centimetersperhour)
        {
            return centimetersperhour.HasValue ? FromCentimetersPerHour(centimetersperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable CentimetersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromCentimetersPerMinutes(QuantityValue? centimetersperminutes)
        {
            return centimetersperminutes.HasValue ? FromCentimetersPerMinutes(centimetersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable CentimetersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromCentimetersPerSecond(QuantityValue? centimeterspersecond)
        {
            return centimeterspersecond.HasValue ? FromCentimetersPerSecond(centimeterspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable DecimetersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromDecimetersPerMinutes(QuantityValue? decimetersperminutes)
        {
            return decimetersperminutes.HasValue ? FromDecimetersPerMinutes(decimetersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable DecimetersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromDecimetersPerSecond(QuantityValue? decimeterspersecond)
        {
            return decimeterspersecond.HasValue ? FromDecimetersPerSecond(decimeterspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable FeetPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromFeetPerHour(QuantityValue? feetperhour)
        {
            return feetperhour.HasValue ? FromFeetPerHour(feetperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable FeetPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromFeetPerMinute(QuantityValue? feetperminute)
        {
            return feetperminute.HasValue ? FromFeetPerMinute(feetperminute.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable FeetPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromFeetPerSecond(QuantityValue? feetpersecond)
        {
            return feetpersecond.HasValue ? FromFeetPerSecond(feetpersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable InchesPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromInchesPerHour(QuantityValue? inchesperhour)
        {
            return inchesperhour.HasValue ? FromInchesPerHour(inchesperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable InchesPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromInchesPerMinute(QuantityValue? inchesperminute)
        {
            return inchesperminute.HasValue ? FromInchesPerMinute(inchesperminute.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable InchesPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromInchesPerSecond(QuantityValue? inchespersecond)
        {
            return inchespersecond.HasValue ? FromInchesPerSecond(inchespersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable KilometersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromKilometersPerHour(QuantityValue? kilometersperhour)
        {
            return kilometersperhour.HasValue ? FromKilometersPerHour(kilometersperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable KilometersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromKilometersPerMinutes(QuantityValue? kilometersperminutes)
        {
            return kilometersperminutes.HasValue ? FromKilometersPerMinutes(kilometersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable KilometersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromKilometersPerSecond(QuantityValue? kilometerspersecond)
        {
            return kilometerspersecond.HasValue ? FromKilometersPerSecond(kilometerspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable Knots.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromKnots(QuantityValue? knots)
        {
            return knots.HasValue ? FromKnots(knots.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MetersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMetersPerHour(QuantityValue? metersperhour)
        {
            return metersperhour.HasValue ? FromMetersPerHour(metersperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MetersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMetersPerMinutes(QuantityValue? metersperminutes)
        {
            return metersperminutes.HasValue ? FromMetersPerMinutes(metersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MetersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMetersPerSecond(QuantityValue? meterspersecond)
        {
            return meterspersecond.HasValue ? FromMetersPerSecond(meterspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MicrometersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMicrometersPerMinutes(QuantityValue? micrometersperminutes)
        {
            return micrometersperminutes.HasValue ? FromMicrometersPerMinutes(micrometersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MicrometersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMicrometersPerSecond(QuantityValue? micrometerspersecond)
        {
            return micrometerspersecond.HasValue ? FromMicrometersPerSecond(micrometerspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MilesPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMilesPerHour(QuantityValue? milesperhour)
        {
            return milesperhour.HasValue ? FromMilesPerHour(milesperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MillimetersPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMillimetersPerHour(QuantityValue? millimetersperhour)
        {
            return millimetersperhour.HasValue ? FromMillimetersPerHour(millimetersperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MillimetersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMillimetersPerMinutes(QuantityValue? millimetersperminutes)
        {
            return millimetersperminutes.HasValue ? FromMillimetersPerMinutes(millimetersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable MillimetersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromMillimetersPerSecond(QuantityValue? millimeterspersecond)
        {
            return millimeterspersecond.HasValue ? FromMillimetersPerSecond(millimeterspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable NanometersPerMinutes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromNanometersPerMinutes(QuantityValue? nanometersperminutes)
        {
            return nanometersperminutes.HasValue ? FromNanometersPerMinutes(nanometersperminutes.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable NanometersPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromNanometersPerSecond(QuantityValue? nanometerspersecond)
        {
            return nanometerspersecond.HasValue ? FromNanometersPerSecond(nanometerspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable UsSurveyFeetPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromUsSurveyFeetPerHour(QuantityValue? ussurveyfeetperhour)
        {
            return ussurveyfeetperhour.HasValue ? FromUsSurveyFeetPerHour(ussurveyfeetperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable UsSurveyFeetPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromUsSurveyFeetPerMinute(QuantityValue? ussurveyfeetperminute)
        {
            return ussurveyfeetperminute.HasValue ? FromUsSurveyFeetPerMinute(ussurveyfeetperminute.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable UsSurveyFeetPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromUsSurveyFeetPerSecond(QuantityValue? ussurveyfeetpersecond)
        {
            return ussurveyfeetpersecond.HasValue ? FromUsSurveyFeetPerSecond(ussurveyfeetpersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable YardsPerHour.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromYardsPerHour(QuantityValue? yardsperhour)
        {
            return yardsperhour.HasValue ? FromYardsPerHour(yardsperhour.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable YardsPerMinute.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromYardsPerMinute(QuantityValue? yardsperminute)
        {
            return yardsperminute.HasValue ? FromYardsPerMinute(yardsperminute.Value) : default(Speed?);
        }

        /// <summary>
        ///     Get nullable Speed from nullable YardsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Speed? FromYardsPerSecond(QuantityValue? yardspersecond)
        {
            return yardspersecond.HasValue ? FromYardsPerSecond(yardspersecond.Value) : default(Speed?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpeedUnit" /> to <see cref="Speed" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Speed unit value.</returns>
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Speed? From(QuantityValue? value, SpeedUnit fromUnit)
        {
            return value.HasValue ? new Speed((double)value.Value, fromUnit) : default(Speed?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(SpeedUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static Speed operator -(Speed right)
        {
            return new Speed(-right.Value, right.Unit);
        }

        public static Speed operator +(Speed left, Speed right)
        {
            return new Speed(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Speed operator -(Speed left, Speed right)
        {
            return new Speed(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Speed operator *(double left, Speed right)
        {
            return new Speed(left * right.Value, right.Unit);
        }

        public static Speed operator *(Speed left, double right)
        {
            return new Speed(left.Value * right, left.Unit);
        }

        public static Speed operator /(Speed left, double right)
        {
            return new Speed(left.Value / right, left.Unit);
        }

        public static double operator /(Speed left, Speed right)
        {
            return left.MetersPerSecond / right.MetersPerSecond;
        }

        #endregion

        public static bool operator <=(Speed left, Speed right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Speed left, Speed right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Speed left, Speed right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Speed left, Speed right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Speed left, Speed right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Speed left, Speed right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Speed Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Speed, SpeedUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    SpeedUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromMetersPerSecond(x.MetersPerSecond + y.MetersPerSecond));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Speed result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Speed);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from .NET Framework targets.")]
        public static SpeedUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static SpeedUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<SpeedUnit>(str.Trim());

            if (unit == SpeedUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized SpeedUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(SpeedUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(SpeedUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(SpeedUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
