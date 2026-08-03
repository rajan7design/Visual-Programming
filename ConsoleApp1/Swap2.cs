using System;


class Swap2
{
    public void s( double a, double b)
    {
        double temp = a;
        a = b;
        b = temp;

        Console.WriteLine( "After Swap:-" + "a=" + a + " b=" + b );
    }
}

