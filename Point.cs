using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    public class Point
    {
        //fields
        private double x,y; 
        //properties
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        //constructors
        public Point()
        { }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //finalizers
        ~Point()
        { }
        //method
        public void Input()
        {
            Console.WriteLine("Nhap X:");
            this.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Y:");
            this.y = double.Parse(Console.ReadLine());
        }
            public void Input(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Output()
        {
            Console.WriteLine("X= " + this.x);
            Console.WriteLine("Y= " + this.y);
        }
    }
}

