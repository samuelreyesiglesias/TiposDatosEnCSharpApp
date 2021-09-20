using System;

namespace TiposDatosEnCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            //Tamano es un 1 byte o su equivalente a 8 bits
            byte ByteMinimo = 0;
            byte ByteMaximo = 255;

            //Tamano 2 bytes o 16 bits
            char CharMinimo = ' ';//minimo un espacio
            char CharMaximo = 'd';//cualquier caracter unicode, solamente uno.

            //2 bytes o 16 bits
            short ShortMinimoSigned = -32768;
            short ShortMaximoSigned = 32767;

            //ocupa 2 bytes
            //u de unsigned , significa sin signo
            ushort UnsignedShortMinimo = 0;
            ushort UnignedShortMaximo = 65535;

            //4 bytes o 32 bits
            int IntMinimoSigned = -2147483648;
            int IntMaximoSigned = 2147483647;

            //Aclaracion...
            //int y int32
            int Numero;//32 bits
            Int32 NumeroX; //32 bits
            //int16 
            //int64


            //4 bytes o 32 bits
            uint UnsignedIntMinimo = 0;
            uint UnsignedIntMaximo = 4294967295;

            //8 bytes o 64 bits
            long longMinimo = -9223372036854775808;
            long LongMaximo = 9223372036854775807;

            //8 bytes o 64 bits
            ulong ULongMinimo = 0;
            ulong ULongMaximo = 18446744073709551615;

            //8 bytes o 64 bits
            //De 15 a 17 dígitos aproximadamente
            double DoubleNegativo = -5 * 10 ^ (-324);
            double DoublePositivo = 17 ^ (308);

            //4 bytes o 32 bits
            //De 6 a 9 dígitos aproximadamente
            float FloatMinimo = (-15) ^ -45;
            float FloatMaximo = (34) ^ 38;

            //16 bytes 
            //28-29 dígitos
            decimal DecimalMinimo = (-10) ^ -28;
            decimal DecimalMaximo = (792280) ^ 28;

            //16 bits o 2 bytes
            //String 
            //Desde 0 o mas caracteres Unicode
            string StringMinimo = "2";
            string StringMaximo = "123122323aadadadddasdas@@4567890abcdefghijklmnopqrstuvwxyz,.!~ACEPTA TODOS LOS CARACTERES UNICODE";


            //1 byte , 8 bits
            //Boleano
            bool BooleanoMinimo = false;
            bool BooleanoMaximo = true;





            Console.WriteLine("Hello World!");
        }
    }
}
