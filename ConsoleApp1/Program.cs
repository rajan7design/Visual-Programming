using System;

    public class Program
    {
       public static void Main(string[] args)
        {
         Console.WriteLine("MR. Rajan");

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
        }
    }
