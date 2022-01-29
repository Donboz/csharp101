using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama operatörleri
            //= += -= /= *=

            int x = 2; 
            x += x;
            print(x);
            x -= x;
            print(x);
            x *= x;
            print(x);
            x /= 2;
            print(x);

            //Mantıksal Operatörleri
            // && || !

            bool at=true,bt=true;
            if(at && bt)
            {
                print("true & true");
            }else if (at || bt)
            {
                print("true or true");
            }else if (!at && bt)
            {
                print("false and true");
            }
            //İlişki operatörleri
            // < > != == >= <=

            int a=2,b=3;

            if(a > b)
            {
                print(true);
            }else if (a == b)
            {
                print(false);
            }

            //Aritmetik operatörler
            // + - * / % ++ --
            int sayi1=12,sayi2=24,mod1=3,mod2=20;

            print(sayi1+sayi2);
            print(sayi1-sayi2);
            print(sayi1*sayi2);
            print(sayi2/sayi1);
            print(sayi1--);
            print(sayi2++);
            print(mod2%mod1);
        }

        static void print(object x)
        {
            string str = x.ToString();
            Console.WriteLine(str);
        }
    }
}
