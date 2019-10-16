using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    static public class ExpectedResults
    {
        static public TestRecordLong[] Result = new TestRecordLong[] {
            new TestRecordLong(1000000000000, @"UN BILLON DE PESOS "),
            new TestRecordLong(1000000000001, @"UN BILLON UN PESOS "),
            new TestRecordLong(1007001, @"UN MILLON SIETE MIL UN PESOS "),
            new TestRecordLong(8446744073709551616, @"OCHO TRILLONES CUATROCIENTOS CUARENTA Y SEIS MIL SETECIENTOS CUARENTA Y CUATRO BILLONES SETENTA Y TRES MIL SETECIENTOS NUEVE MILLONES QUINIENTOS CINCUENTA Y UN MIL SEISCIENTOS DIECISÉIS PESOS "),
            new TestRecordLong(7001, @"SIETE MIL UN PESOS "),
            new TestRecordLong(1, @"UN PESO "),
            new TestRecordLong(1000, @"MIL PESOS "),
            new TestRecordLong(1000000000, @"MIL MILLONES DE PESOS "),
            new TestRecordLong(1000000000000000, @"MIL BILLONES DE PESOS "),
            new TestRecordLong(1001000000000, @"UN BILLON MIL MILLONES DE PESOS "),
            new TestRecordLong(1007001, @"UN MILLON SIETE MIL UN PESOS "),
            new TestRecordLong(8446744073709551616, @"OCHO TRILLONES CUATROCIENTOS CUARENTA Y SEIS MIL SETECIENTOS CUARENTA Y CUATRO BILLONES SETENTA Y TRES MIL SETECIENTOS NUEVE MILLONES QUINIENTOS CINCUENTA Y UN MIL SEISCIENTOS DIECISÉIS PESOS "),
            new TestRecordLong(7001, @"SIETE MIL UN PESOS "),
            new TestRecordLong(1000, @"MIL PESOS "),
            new TestRecordLong(1000000000, @"MIL MILLONES DE PESOS "),
            new TestRecordLong(1000000000000000, @"MIL BILLONES DE PESOS "),
            new TestRecordLong(10, @"DIEZ PESOS "),
            new TestRecordLong(100, @"CIEN PESOS "),
            new TestRecordLong(1000, @"MIL PESOS "),
            new TestRecordLong(10000, @"DIEZ MIL PESOS "),
            new TestRecordLong(100000, @"CIEN MIL PESOS "),
            new TestRecordLong(1000000, @"UN MILLON DE PESOS "),
            new TestRecordLong(10000000, @"DIEZ MILLONES DE PESOS "),
            new TestRecordLong(100000000, @"CIEN MILLONES DE PESOS "),
            new TestRecordLong(1000000000, @"MIL MILLONES DE PESOS "),
            new TestRecordLong(10000000000, @"DIEZ MIL MILLONES DE PESOS "),
            new TestRecordLong(100000000000, @"CIEN MIL MILLONES DE PESOS "),
            new TestRecordLong(1000000000000, @"UN BILLON DE PESOS "),
            new TestRecordLong(10000000000000, @"DIEZ BILLONES DE PESOS "),
            new TestRecordLong(100000000000000, @"CIEN BILLONES DE PESOS "),
            new TestRecordLong(1000000000000000, @"MIL BILLONES DE PESOS "),
            new TestRecordLong(10000000000000000, @"DIEZ MIL BILLONES DE PESOS "),
            new TestRecordLong(100000000000000000, @"CIEN MIL BILLONES DE PESOS "),
            new TestRecordLong(1000000000000000000, @"UN TRILLON DE PESOS "),
            new TestRecordLong(1000001000000000, @"MIL BILLONES MIL MILLONES DE PESOS "),
            new TestRecordLong(Int64.MinValue, @"MENOS NUEVE TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS OCHO PESOS "),
            new TestRecordLong(Int64.MaxValue, @"NUEVE TRILLONES DOCIENTOS VEINTITRES MIL TRECIENTOS SETENTA Y DOS BILLONES TREINTA Y SEIS MIL OCHOCIENTOS CINCUENTA Y CUATRO MILLONES SETECIENTOS SETENTA Y CINCO MIL OCHOCIENTOS SIETE PESOS "),
            new TestRecordLong(0, @"CERO PESOS "),   // no respeta la regla de un blanco al final
            new TestRecordLong(1, @"UN PESO "),
            new TestRecordLong(2, @"DOS PESOS "),
            new TestRecordLong(3, @"TRES PESOS "),
            new TestRecordLong(4, @"CUATRO PESOS "),
            new TestRecordLong(5, @"CINCO PESOS "),
            new TestRecordLong(6, @"SEIS PESOS "),
            new TestRecordLong(7, @"SIETE PESOS "),
            new TestRecordLong(8, @"OCHO PESOS "),
            new TestRecordLong(9, @"NUEVE PESOS "),
            new TestRecordLong(10, @"DIEZ PESOS "),
            new TestRecordLong(11, @"ONCE PESOS "),
            new TestRecordLong(12, @"DOCE PESOS "),
            new TestRecordLong(13, @"TRECE PESOS "),
            new TestRecordLong(14, @"CATORCE PESOS "),
            new TestRecordLong(15, @"QUINCE PESOS "),
            new TestRecordLong(16, @"DIECISÉIS PESOS "),
            new TestRecordLong(17, @"DIECISIETE PESOS "),
            new TestRecordLong(18, @"DIECIOCHO PESOS "),
            new TestRecordLong(19, @"DIECINUEVE PESOS "),
            new TestRecordLong(20, @"VEINTE PESOS "),
            new TestRecordLong(21, @"VEINTIUN PESOS "),
            new TestRecordLong(22, @"VEINTIDOS PESOS "),
            new TestRecordLong(23, @"VEINTITRES PESOS "),
            new TestRecordLong(24, @"VEINTICUATRO PESOS "),
            new TestRecordLong(25, @"VEINTICINCO PESOS "),
            new TestRecordLong(26, @"VEINTISEIS PESOS "),
            new TestRecordLong(27, @"VEINTISIETE PESOS "),
            new TestRecordLong(28, @"VEINTIOCHO PESOS "),
            new TestRecordLong(29, @"VEINTINUEVE PESOS "),
            new TestRecordLong(30, @"TREINTA PESOS "),
            new TestRecordLong(31, @"TREINTA Y UN PESOS "),
            new TestRecordLong(32, @"TREINTA Y DOS PESOS "),
            new TestRecordLong(33, @"TREINTA Y TRES PESOS "),
            new TestRecordLong(34, @"TREINTA Y CUATRO PESOS "),
            new TestRecordLong(40, @"CUARENTA PESOS "),
            new TestRecordLong(41, @"CUARENTA Y UN PESOS "),
            new TestRecordLong(50, @"CINCUENTA PESOS "),
            new TestRecordLong(52, @"CINCUENTA Y DOS PESOS "),
            new TestRecordLong(60, @"SESENTA PESOS "),
            new TestRecordLong(70, @"SETENTA PESOS "),
            new TestRecordLong(80, @"OCHENTA PESOS "),
            new TestRecordLong(90, @"NOVENTA PESOS "),
            new TestRecordLong(100, @"CIEN PESOS "),
            new TestRecordLong(101, @"CIENTO UN PESOS "),
            new TestRecordLong(200, @"DOCIENTOS PESOS "),
            new TestRecordLong(333, @"TRECIENTOS TREINTA Y TRES PESOS "),
            new TestRecordLong(456, @"CUATROCIENTOS CINCUENTA Y SEIS PESOS "),
            new TestRecordLong(01000, @"MIL PESOS "),
            new TestRecordLong(1000000, @"UN MILLON DE PESOS "),
            new TestRecordLong(1000000000000, @"UN BILLON DE PESOS "),
            new TestRecordLong(99, @"NOVENTA Y NUEVE PESOS "),
            new TestRecordLong(120, @"CIENTO VEINTE PESOS "),
            new TestRecordLong(1111111111, @"MIL CIENTO ONCE MILLONES CIENTO ONCE MIL CIENTO ONCE PESOS ")
        };
    }

    public class TestRecordLong // long
    {
        public long num;
        public string EnPalabras;
        public TestRecordLong(long num, string EnPalabras)
        {
            this.num = num;
            this.EnPalabras = EnPalabras;
        }
    }

    public class TestRecordUlong // ulong
    {
        public ulong num;
        public string EnPalabras;
        public TestRecordUlong(ulong num, string EnPalabras)
        {
            this.num = num;
            this.EnPalabras = EnPalabras;
        }
    }

    public class TestRecordDouble // double
    {
        public double num;
        public string EnPalabras;
        public TestRecordDouble(double num, string EnPalabras)
        {
            this.num = num;
            this.EnPalabras = EnPalabras;
        }
    }

    public class TestRecordDecimal // decimal
    {
        public decimal num;
        public string EnPalabras;
        public TestRecordDecimal(decimal num, string EnPalabras)
        {
            this.num = num;
            this.EnPalabras = EnPalabras;
        }
    }
}
