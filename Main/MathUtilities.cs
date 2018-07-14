using System;
namespace Csharp.Fundamentals
{
    public class MathUtilities
    {
        #region Integer types

        //byte 8-bit signed integer, min = 0 max = 255 (nonnegative) default 0
        public byte Subtract(byte baseValue, byte difference)
        {
            return (byte)(baseValue - difference);
        }

        public byte Divide(byte dividend, byte divisor)
        {
            return (byte)(dividend / divisor);
        }

        public byte Multiply(byte multiplicand, byte multiplier)
        {
            return (byte)(multiplicand * multiplier);
        }

        //sbyte 8-signed integer, min = -128 max = 127 default 0
        public sbyte Add(sbyte baseValue, sbyte difference)
        {

            return (sbyte)(baseValue + difference);
        }
        public sbyte Subtract(byte baseValue, sbyte difference)
        {
            return (sbyte)(baseValue - difference);
        }

        public sbyte Divide(sbyte dividend, sbyte divisor)
        {
            return (sbyte)(dividend / divisor);
        }

        public sbyte Multiply(sbyte multiplicand, sbyte multiplier)
        {
            return (sbyte)(multiplicand * multiplier);
        }

        //short 16-bit signed integer, min = -32768 max = 32767 default 0
        public short Add(short baseValue, short difference)
        {

            return (short)(baseValue + difference);
        }
        public short Subtract(short baseValue, short difference)
        {

            return (short)(baseValue - difference);
        }

        public short Divide(short dividend, short divisor)
        {
            return (short)(dividend / divisor);
        }
        public short Multiply(short multiplicand, short multiplier)
        {
            return (short)(multiplicand * multiplier);
        }
        //ushort 16-bit unsigned integer min = 0 max = 65535 default 0
        public ushort Add(short baseValue, ushort difference)
        {

            return (ushort)(baseValue + difference);
        }
        public ushort Subtract(ushort baseValue, ushort difference)
        {

            return (ushort)(baseValue - difference);
        }

        public ushort Divide(ushort dividend, ushort divisor)
        {
            return (ushort)(dividend / divisor);
        }
        public ushort Multiply(ushort multiplicand, ushort multiplier)
        {
            return (ushort)(multiplicand * multiplier);
        }

        //int 32-bit signed integer min value = -2147483648 max value = 2147483647 default 0
        public int Add(int baseValue, int difference)
        {
            return baseValue + difference;
        }
        public int Subtract(int baseValue, int difference)
        {

            return baseValue - difference;
        }

        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        public int Multiply(int multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        //uint 32-bit unsigned integer min =0 max = 4294967295 default = 0u, 0U
        public uint Add(uint baseValue, uint difference)
        {
            return baseValue + difference;
        }
        public uint Subtract(uint baseValue, uint difference)
        {

            return baseValue - difference;
        }

        public uint Divide(uint dividend, uint divisor)
        {
            return dividend / divisor;
        }

        public uint Multiply(uint multiplicand, uint multiplier)
        {
            return multiplicand * multiplier;
        }

        //long 64-bit signed type min = -9223372036854775808 max = 9223372036854775807 default 0L
        public long Add(long baseValue, long difference)
        {
            return baseValue + difference;
        }
        public long Subtract(long baseValue, long difference)
        {

            return baseValue - difference;
        }
        public long Divide(long dividend, long divisor)
        {
            return dividend / divisor;
        }
        public long Multiply(long multiplicand, long multiplier)
        {
            return multiplicand * multiplier;
        }

        //long 64-bit unsigned type min = 0 max = 18446744073709551615 default = 0u
        public ulong Add(ulong baseValue, ulong difference)
        {
            return baseValue + difference;
        }
        public ulong Subtract(ulong baseValue, ulong difference)
        {

            return baseValue - difference;
        }
        public ulong Divide(ulong dividend, ulong divisor)
        {
            return dividend / divisor;
        }
        public ulong Multiply(ulong multiplicand, ulong multiplier)
        {
            return multiplicand * multiplier;
        }
        #endregion Integer type

        #region Real Floating Point Type
        // float 32-bit real min = ±1.5×10-45  max = ±3.4×1038 default = 0.0f, 0.0F 
        //by default all floating point num are double must use f to indicate float
        //single precision number accuracy up to 7 decimal places (the others are lost)
        //prone to error and appropriate for financial calculations
        public float Add(float baseValue, float difference)
        {

            return baseValue + difference;
        }
        public float Subtract(float baseValue, float difference)
        {
            return baseValue - difference;
        }
        public float Divide(float dividend, float divisor)
        {
            return dividend / divisor;
        }
        public float Multiply(float multiplicand, float multiplier)
        {
            return multiplicand * multiplier;
        }

        // double 64-bit type min = ±5.0×10-324  max = ±1.7×10308 default = 0.0d, 0.0D 
        //must use d to indicate double
        //double precision real num accuracy up to 15-16 digits
        public double Add(double baseValue, double difference)
        {

            return baseValue + difference;
        }
       
        public double Subtract(double baseValue, double difference)
        {
            return baseValue - difference;
        }
        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }
        public double Multiply(double multiplicand, double multiplier)
        {
            return multiplicand * multiplier;
        }
        #endregion Real Floating Point Type

        #region Real Type with decimal precision
        //decimal 128-bit min = ±1.0×10-28 max = ±7.9×1028 default = 0.0m, 0.0M
        //m indicates decimal cus by deafult all real num are double
        //precision of 28 29 decimal places
        //numbers represented ad decimal numeral system and not binary, does not lose accuracy, 
        //great for financial calculations
        public decimal Add(decimal baseValue, decimal difference)
        {

            return baseValue + difference;
        }

        public decimal Subtract(decimal baseValue, decimal difference)
        {
            return baseValue - difference;
        }
        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
        public decimal Multiply(decimal multiplicand, decimal multiplier)
        {
            return multiplicand * multiplier;
        }
        #endregion Real Type with decimal precision

        #region Boolean type
        //2 values true or false, often stored in result of logical expressions
        public bool ReturnTrue()
        {
            return true;
        }

        public bool ReturnFalse()
        {
            return false;
        }
        #endregion Boolean type

    }
}
