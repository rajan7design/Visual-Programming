// Create variables for five subject marks and calculate the average.

using System;
using System.Globalization;
class Average
{
    public void Hello ( double m, double s, double n, double v, double c)
    {
        
        double result = ( m + s + n + v + c) / 5;
        Console.WriteLine ( " The average is:- " + result );
    }
}