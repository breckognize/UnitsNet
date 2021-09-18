//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In chemistry, the molar mass M is a physical property defined as the mass of a given substance (chemical element or chemical compound) divided by the amount of substance.
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class MolarMass : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarMassUnit? _unit;

        static MolarMass()
        {
            BaseDimensions = new BaseDimensions(0, 1, 0, 0, 0, -1, 0, 0);
            Info = new QuantityInfo(QuantityType.MolarMass, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit KilogramPerMole.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public MolarMass()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private MolarMass(double value, MolarMassUnit unit)
        {
            if(unit == MolarMassUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of MolarMass, which is KilogramPerMole. All conversions go via this value.
        /// </summary>
        public static MolarMassUnit BaseUnit { get; } = MolarMassUnit.KilogramPerMole;

        /// <summary>
        /// Represents the largest possible value of MolarMass
        /// </summary>
        public static MolarMass MaxValue { get; } = new MolarMass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MolarMass
        /// </summary>
        public static MolarMass MinValue { get; } = new MolarMass(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.MolarMass;

        /// <summary>
        ///     All units of measurement for the MolarMass quantity.
        /// </summary>
        public static MolarMassUnit[] Units { get; } = Enum.GetValues(typeof(MolarMassUnit)).Cast<MolarMassUnit>().Except(new MolarMassUnit[]{ MolarMassUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit KilogramPerMole.
        /// </summary>
        public static MolarMass Zero { get; } = new MolarMass(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MolarMassUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => MolarMass.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => MolarMass.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get MolarMass in CentigramsPerMole.
        /// </summary>
        public double CentigramsPerMole => As(MolarMassUnit.CentigramPerMole);

        /// <summary>
        ///     Get MolarMass in DecagramsPerMole.
        /// </summary>
        public double DecagramsPerMole => As(MolarMassUnit.DecagramPerMole);

        /// <summary>
        ///     Get MolarMass in DecigramsPerMole.
        /// </summary>
        public double DecigramsPerMole => As(MolarMassUnit.DecigramPerMole);

        /// <summary>
        ///     Get MolarMass in GramsPerMole.
        /// </summary>
        public double GramsPerMole => As(MolarMassUnit.GramPerMole);

        /// <summary>
        ///     Get MolarMass in HectogramsPerMole.
        /// </summary>
        public double HectogramsPerMole => As(MolarMassUnit.HectogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilogramsPerMole.
        /// </summary>
        public double KilogramsPerMole => As(MolarMassUnit.KilogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilopoundsPerMole.
        /// </summary>
        public double KilopoundsPerMole => As(MolarMassUnit.KilopoundPerMole);

        /// <summary>
        ///     Get MolarMass in MegapoundsPerMole.
        /// </summary>
        public double MegapoundsPerMole => As(MolarMassUnit.MegapoundPerMole);

        /// <summary>
        ///     Get MolarMass in MicrogramsPerMole.
        /// </summary>
        public double MicrogramsPerMole => As(MolarMassUnit.MicrogramPerMole);

        /// <summary>
        ///     Get MolarMass in MilligramsPerMole.
        /// </summary>
        public double MilligramsPerMole => As(MolarMassUnit.MilligramPerMole);

        /// <summary>
        ///     Get MolarMass in NanogramsPerMole.
        /// </summary>
        public double NanogramsPerMole => As(MolarMassUnit.NanogramPerMole);

        /// <summary>
        ///     Get MolarMass in PoundsPerMole.
        /// </summary>
        public double PoundsPerMole => As(MolarMassUnit.PoundPerMole);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(MolarMassUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(MolarMassUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get MolarMass from CentigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromCentigramsPerMole(double centigramspermole)
        {
            double value = (double) centigramspermole;
            return new MolarMass(value, MolarMassUnit.CentigramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from DecagramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromDecagramsPerMole(double decagramspermole)
        {
            double value = (double) decagramspermole;
            return new MolarMass(value, MolarMassUnit.DecagramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from DecigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromDecigramsPerMole(double decigramspermole)
        {
            double value = (double) decigramspermole;
            return new MolarMass(value, MolarMassUnit.DecigramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from GramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromGramsPerMole(double gramspermole)
        {
            double value = (double) gramspermole;
            return new MolarMass(value, MolarMassUnit.GramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from HectogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromHectogramsPerMole(double hectogramspermole)
        {
            double value = (double) hectogramspermole;
            return new MolarMass(value, MolarMassUnit.HectogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from KilogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromKilogramsPerMole(double kilogramspermole)
        {
            double value = (double) kilogramspermole;
            return new MolarMass(value, MolarMassUnit.KilogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from KilopoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromKilopoundsPerMole(double kilopoundspermole)
        {
            double value = (double) kilopoundspermole;
            return new MolarMass(value, MolarMassUnit.KilopoundPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MegapoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMegapoundsPerMole(double megapoundspermole)
        {
            double value = (double) megapoundspermole;
            return new MolarMass(value, MolarMassUnit.MegapoundPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MicrogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMicrogramsPerMole(double microgramspermole)
        {
            double value = (double) microgramspermole;
            return new MolarMass(value, MolarMassUnit.MicrogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from MilligramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMilligramsPerMole(double milligramspermole)
        {
            double value = (double) milligramspermole;
            return new MolarMass(value, MolarMassUnit.MilligramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from NanogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromNanogramsPerMole(double nanogramspermole)
        {
            double value = (double) nanogramspermole;
            return new MolarMass(value, MolarMassUnit.NanogramPerMole);
        }
        /// <summary>
        ///     Get MolarMass from PoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromPoundsPerMole(double poundspermole)
        {
            double value = (double) poundspermole;
            return new MolarMass(value, MolarMassUnit.PoundPerMole);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarMassUnit" /> to <see cref="MolarMass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarMass unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static MolarMass From(double value, MolarMassUnit fromUnit)
        {
            return new MolarMass((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
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
        public static MolarMass Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static MolarMass Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<MolarMass, MolarMassUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out MolarMass result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out MolarMass result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<MolarMass, MolarMassUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarMassUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static MolarMassUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<MolarMassUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out MolarMassUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out MolarMassUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<MolarMassUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is MolarMass objMolarMass)) throw new ArgumentException("Expected type MolarMass.", nameof(obj));

            return CompareTo(objMolarMass);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(MolarMass other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is MolarMass objMolarMass))
                return false;

            return Equals(objMolarMass);
        }

        public bool Equals(MolarMass other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another MolarMass within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(MolarMass other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current MolarMass.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((MolarMassUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarMassUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this MolarMass to another MolarMass with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A MolarMass with the specified unit.</returns>
        public MolarMass ToUnit(MolarMassUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new MolarMass(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case MolarMassUnit.CentigramPerMole: return (_value/1e3) * 1e-2d;
                case MolarMassUnit.DecagramPerMole: return (_value/1e3) * 1e1d;
                case MolarMassUnit.DecigramPerMole: return (_value/1e3) * 1e-1d;
                case MolarMassUnit.GramPerMole: return _value/1e3;
                case MolarMassUnit.HectogramPerMole: return (_value/1e3) * 1e2d;
                case MolarMassUnit.KilogramPerMole: return (_value/1e3) * 1e3d;
                case MolarMassUnit.KilopoundPerMole: return (_value*0.45359237) * 1e3d;
                case MolarMassUnit.MegapoundPerMole: return (_value*0.45359237) * 1e6d;
                case MolarMassUnit.MicrogramPerMole: return (_value/1e3) * 1e-6d;
                case MolarMassUnit.MilligramPerMole: return (_value/1e3) * 1e-3d;
                case MolarMassUnit.NanogramPerMole: return (_value/1e3) * 1e-9d;
                case MolarMassUnit.PoundPerMole: return _value*0.45359237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MolarMassUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MolarMassUnit.CentigramPerMole: return (baseUnitValue*1e3) / 1e-2d;
                case MolarMassUnit.DecagramPerMole: return (baseUnitValue*1e3) / 1e1d;
                case MolarMassUnit.DecigramPerMole: return (baseUnitValue*1e3) / 1e-1d;
                case MolarMassUnit.GramPerMole: return baseUnitValue*1e3;
                case MolarMassUnit.HectogramPerMole: return (baseUnitValue*1e3) / 1e2d;
                case MolarMassUnit.KilogramPerMole: return (baseUnitValue*1e3) / 1e3d;
                case MolarMassUnit.KilopoundPerMole: return (baseUnitValue/0.45359237) / 1e3d;
                case MolarMassUnit.MegapoundPerMole: return (baseUnitValue/0.45359237) / 1e6d;
                case MolarMassUnit.MicrogramPerMole: return (baseUnitValue*1e3) / 1e-6d;
                case MolarMassUnit.MilligramPerMole: return (baseUnitValue*1e3) / 1e-3d;
                case MolarMassUnit.NanogramPerMole: return (baseUnitValue*1e3) / 1e-9d;
                case MolarMassUnit.PoundPerMole: return baseUnitValue/0.45359237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
