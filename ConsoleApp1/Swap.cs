using System;
class Swap
{
    public void demo (double a, double b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
        
           Console.WriteLine( " After Swap:" + " a=" + a + " b=" + b );
    }
}