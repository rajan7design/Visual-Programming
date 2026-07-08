//Declare variables for principal, rate, and time, then calculate simple interest.

using System;

class SimpleInterest
{
    public void Interest( double principal, double rate, double time)
    {
      double Simple = (principal * rate * time) / 100 ;  
      Console.WriteLine ( " The Simple Interest is:" + Simple );
    }
}