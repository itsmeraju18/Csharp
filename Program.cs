// c# program to calculate the area
// of a square using abstract clss
// & abstract method
using System;
// declare class 'AreaClass'
// as abstract
abstract class AreaClass
{
    // declare method
    //'Area' as abstract
    abstract public int Area();
}
//class 'AreaClass' inherit
//in child class 'Square'
class Square : AreaClass
{
    int side = 0;
    // constructor
    public Square(int n)
    {
        side = n;
    }
    // the abstract method
    // 'Area' is override int Area()
    public override int Area()
    {
        return side * side;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
        Square s = new Square(6);
        Console.WriteLine("Area = " + s.Area());
        }
    }

