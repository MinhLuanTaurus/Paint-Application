using System;
using System.Collections.Generic;
using System.Text;

namespace Paint
{
    class ComplexObject
    {
            private List<Shape> LdsShape;

            public List<Shape> ldsShape { get => this.LdsShape; set => LdsShape = value; }
            public ComplexObject()
            {
                this.LdsShape = new List<Shape>();
            }
            ~ ComplexObject()
                {

                }
        public void Input()
        {
            Triangle tri = new Triangle();
            tri.Input();
            this.LdsShape.Add(tri);
        
        }
        public void Output()
        {

        }

        }
    }


/* 
 *int sRec, sTri, sLine, sCirlce;
                Console.Write("Amount Line: ");
            sLine = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sLine; i++)
                {
                    Line temp = new Line();
                    temp.Input();
                    this.LdsShape.Add(temp);
                }
                Console.Write("Nhap so Rectangle: ");
                sRec = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sRec; i++)
                {
                    Retangle temp = new Retangle();
                    temp.Input();
                    this.LdsShape.Add(temp);
                }

                Console.Write("Nhap so Triangle: ");
                sTri  = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sTri; i++)
                {
                    Triangle temp = new Triangle();
                    temp.Input();
                    this.LdsShape.Add(temp);
                }
 */