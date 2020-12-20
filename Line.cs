using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class Line:Shape
    {
        //fields
        private double dlength;
        //properties    
        public double length
        {
            get { return this.dlength; }
            set { this.dlength = value; }
        }
        //constructors
        public Line() : base()
        {

        }
        //finalizers
        ~Line()
        { }
        //methods
        public override void Input()
        {
            base.Input();
        }
        public void getLength()
        {
            this.dlength = Math.Sqrt(Math.Pow(this.P1.X - this.P2.X, 2) + Math.Pow(this.P1.Y - this.P1.Y, 2));
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Do dai= " + this.dlength);
        }

        public override void Draw()
        {
            

        }
        public override void Calcul_Area() { }
        public override void Move()
        {

        }
    }
}
