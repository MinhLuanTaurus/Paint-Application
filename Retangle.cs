using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class Retangle:Shape
    {
        //fields
        private double dheight; //chieu cao hinh chu nhat
        private double dwidth; // chieu rong hinh chu nhat
        private double dRetangle_Area; 
        public double height
        {
            get { return this.dheight;}
            set { this.dheight = value;}
        }
        public double width
        {
            get { return this.dwidth; }
            set { this.dwidth = value; }
        }
        public double Retangle_Area
        {
            get { return this.dRetangle_Area;}
            set { this.dRetangle_Area = value;}
        }
        //Constructors
        public Retangle() : base ()
        {

        }
        ~ Retangle ()
        { }
        //Methods
        public override void Input()
        {
            Console.WriteLine("Nhap hinh chu nhat");
            base.Input();
            this.height = Math.Abs(this.P1.Y - this.P2.Y);
            this.width =  Math.Abs(this.P1.X - this.P2.X); 

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Dien tich hinh chu nhat la: " + this.dRetangle_Area);
        }
        public override void Calcul_Area()
        {
           
        }

        public override void Draw()
        {

        }
        public override void Move()
        {

        }
    }
}
