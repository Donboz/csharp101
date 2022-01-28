using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 3; //1 byte
            sbyte sb= 3; //1 byte

            short s = 3; //2 byte
            ushort us = 3; // 2 byte

            Int16 sayi = 2 ; // 2 byte
            int sayi1 = 2; //4 byte  
            Int32 i32 = 2;//4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            float f = 0.5f; //4 byte
            double d = 0.5; //8 byte
            decimal dc = 5;// 16 byte

            char noOne = 'a'; // 2 byte
            string name = "Murat"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);
        }
    }
}
