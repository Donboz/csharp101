using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implict conversion(bilinçsiz dönüşüm)

            Console.WriteLine("***** Implict *****");
            short a = 15;
            sbyte b = 27;
            byte c = 16;

            int sum = a+b+c;
            Console.WriteLine(sum);

            long d = sum;
            Console.WriteLine(d);
            float l = d;
            Console.WriteLine(l);

            string str = "karakter";
            char chr = 'a';
            object obj = str+chr+d;

            Console.WriteLine("obj: " + obj);

            // Explicit conversion(bilinçli , açık)

            Console.WriteLine("***** Explicit *****");

            float float1 = 1.5f;
            int x = (int)float1;

            Console.WriteLine(x);

            // To ToString

            Console.WriteLine("***** toString *****");

            int strint = 15;
            Console.WriteLine(strint.GetType());
            string intstr = strint.ToString();
            Console.WriteLine(intstr.GetType());

            Console.WriteLine("***** Convert *****");

            string s1 = "63",s2 = "20";
            int num1,num2 ;

            num1= Convert.ToInt32(s1);
            num2= Convert.ToInt32(s2);

            int toplam = num1+num2;

            Console.WriteLine(toplam);

            Console.WriteLine("***** parse Function *****");

            parseMethod();
        }

        public static void parseMethod()
        {
            string m1 = "10";
            string m2 = "10.25";
            int rakam;
            double db1;

            rakam = Int32.Parse(m1);
            db1 = double.Parse(m2);

            Console.WriteLine(rakam);
            Console.WriteLine(db1);
        }
    }
}
