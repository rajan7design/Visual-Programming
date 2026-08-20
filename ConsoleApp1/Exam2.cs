using System;

class Exam2
{
    
    public  void Exammm()
    {
        string name;
    
        int marks;

        for ( int id = 1; id<=4; id++)
        {
            Console.WriteLine ( " ID No:" + id);
            Console.WriteLine ( " Enter your name:- ");
            name = Console.ReadLine();

            Console.WriteLine(" Enter your marks:-");
           marks = Convert.ToInt32(Console.ReadLine());

            if ( marks < 90)
            {
                Console.WriteLine(" Your final grade is A");
               
            }
            
            else if ( marks < 80) {
                Console.WriteLine( " Your final grade is B ");
            }

            else if ( marks < 70) {
                Console.WriteLine( " Your final grade is C ");
            }

            else if ( marks < 60) {
                Console.WriteLine( " Your final grade is D ");
            }

            else   {
                Console.WriteLine( " Your final grade is F ");
            }

            Console.WriteLine(" Your name is " + name);
             Console.WriteLine(" Your  score is " + marks);
            
        }
    }
}