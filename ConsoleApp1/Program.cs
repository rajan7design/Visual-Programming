using System;

    public class Program
    {
       public static void Main(string[] args)
        {
         

         Data o = new Data ();
         o.Dataa(  " Rajan ", 16, " Pokhara, Nepal ");

         Question2 question2 = new Question2();
         question2.Add(3, 4);

         Marks marks = new Marks (); 
         marks.Mark(50, 53, 54 );

         Circle circle = new Circle();
         circle.radius(6.7);

         Perimeter perimeter = new Perimeter();
         perimeter.demo(10, 8);
        
        SimpleInterest simpleinterest = new SimpleInterest();
        simpleinterest.Interest(5000, 12, 2 );

        Swap swap = new Swap ();
        swap.demo(10, 20);

        Swap2 swap2 = new Swap2 ();
        swap2.s(20, 21);

        Average average = new Average ();
        average.Hello( 50, 52, 54, 51, 53);

        Celsius celsius = new Celsius ();
        celsius.Namaste( 32.4 );
        }

    }
