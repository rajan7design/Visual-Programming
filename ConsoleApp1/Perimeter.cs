// Store the length and breadth of a rectangle and calculate the perimeter.

using System;
class Perimeter
{
    public void demo( double length, double breadth )
    {
       double rectangle = 2 * ( length + breadth );

       Console.WriteLine(" The total perimeter is:" + rectangle );
    }
}