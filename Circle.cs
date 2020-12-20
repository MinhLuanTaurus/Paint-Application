using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class Circle:Shape
    {
        private double dRadius, dCircleArea;

        public double Radius
        {
            get { return this.dRadius; }
            set { this.dRadius = value; }
        }
        public double CircleArea
        {
            get { return this.dCircleArea; }
            set { this.dCircleArea = value; }
        }
        public Circle() : base()
        {

        }
        ~Circle()
        { }
        //Methods
        public override void Input()
        {
            base.Input();
            this.dRadius = double.Parse(Console.ReadLine());
        }
          public override void Output()
        {
            base.Output();
            Console.WriteLine("Dien tich hinh tron (R={0}) la: {1}", this.dRadius, this.dCircleArea);
        }   
        public override void Draw()
        {


        }
        public override void Calcul_Area()
        {
            this.dCircleArea = Math.Pow(dRadius, 2) * Math.PI;
        }
    }




}
