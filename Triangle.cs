using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class Triangle : Shape
    {

   
        //fields
        private double dheight;
        private double dcanhday;
        private double dTriangle_Area;
        //properties
        public double height
        {
            get { return this.dheight; }
            set { this.dheight = value; }
        }
        public double DoDaiCanhDay
        {
            get { return this.dcanhday; }
            set { this.dcanhday = value; }
        }
        public double Triangle_Area
        {
            get { return this.dTriangle_Area; }
            set { this.dTriangle_Area = value; }
        }
        //constructors
        public Triangle() : base()
        {

        }
        //finalizers
        ~Triangle()
        { }
        //methods
        public override void Input()
        {
            base.Input();
            this.height = Math.Abs(this.P1.Y - this.P2.Y);
            this.dcanhday = Math.Abs(this.P1.X - this.P2.X);
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Chieu cao tam giac la: ", + this.height);
            Console.WriteLine("Do dai canh day cua tam giac la: ", + this.dcanhday);
            Console.WriteLine("Dien tich hinh tam giac la: ", + this.dTriangle_Area);
        }

          public override void Draw()
        {


        }
        public override void Calcul_Area()
        {
            this.dTriangle_Area = this.height * this.dcanhday * 0.5;
        }
        public override void Move()
        {

        }

    }
}

