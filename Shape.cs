using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    public abstract class Shape
    {
        //fields
        protected Point pP1,pP2;
        protected int iColor;

        //properties
        public int Color
        {
            get { return this.iColor; }
            set { this.iColor = value; }
        }
        public Point P1
        {
            get { return this.pP1; }
            set { this.pP1 = value; }
        }
        public Point P2
        {
            get { return this.pP2; }
            set { this.pP2 = value; }
        }
        //constructors
        public Shape()
        {

        }
        public Shape(Point p1, Point p2, int Color)
        {
            this.pP1 = p1;
            this.pP2 = p2;
            this.iColor = Color;
        }
        //finalizers
        ~Shape()
        { }
        //methods
        public virtual void Input()
        {
            Point P1 = new Point();
            Point P2 = new Point();
            int color = this.iColor;
            P1.Input();
            P2.Input();
            this.pP1 = P1;
            this.pP2 = P2;
        }
        public virtual void Input(Point p1, Point p2, int color)
        {
            this.pP1 = p1;
            this.pP2 = p2;
            this.iColor = color;
        }
        public virtual void Output()
        {
            Console.WriteLine("Point A: ");
            this.pP1.Output();
            Console.WriteLine("Point B: ");
            this.pP2.Output();
            Console.WriteLine("Shape Color is: ", + this.iColor);
        }
        public virtual void ChangeColor(int color)
        {
            Console.WriteLine("Which color do you change?");
            int color_temp = Convert.ToInt32(Console.ReadLine());
            this.iColor = color_temp;
        }
        public virtual void Move(Point pp1, Point pp2)
        {
            pp1.Input();
            pp2.Input();
            this.pP1 = pp1;
            this.pP2 = pp2;
        }
        public abstract void Draw();
        public abstract void Calcul_Area();
        public abstract void Move();


    }
}

