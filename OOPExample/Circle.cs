using System;
namespace OOPExample
{
    public class Circle
    {

        //state
        private double radius;
        private string color;
        //



        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }

        public Circle(double r) {

            this.radius = r;
            this.color = "red";
        }
 
        //behaviour //comportamientoo
        public double getRadius() {
            //other code PASAR COSAS

            return radius;
        }

        public double getArea()
        {
            var radioPower = Math.Pow(radius, 2);
            var area = radioPower * Math.PI;
            return area;
        }
    }
}
