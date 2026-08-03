using System;
class Vote
{
    public void Voting( int age)
    {
        

        if (age >= 18)
        {
            Console.WriteLine("You are eligible for voting");
        }
        else
        {
            Console.WriteLine("You are not eligible for voting");
        }
    }
}