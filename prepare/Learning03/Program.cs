using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        
        frac1.Constructor();
        frac1.GetFractionString();
        frac1.GetDecimalValue();

        frac1.Constructor(5);
        frac1.GetFractionString();
        frac1.GetDecimalValue();

        frac1.Constructor(3,4);
        frac1.GetFractionString();
        frac1.GetDecimalValue();

        frac1.Constructor(1,4);
        frac1.GetFractionString();
        frac1.GetDecimalValue();
    }
}