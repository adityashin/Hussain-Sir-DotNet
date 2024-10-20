using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace  Figure
{
    public abstract class Figures
    {
        public int length {get; set;}
        public int width {get;set;}
        public abstract int Area();
    }

    public class Rectangle : Figures
    {
        public  Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }

        public override int Area()
        {
            return length *width;
        }

    }
    class Triangle : Figures
    {
        public int height {get; set;}
        public Triangle(int length,int width,int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public override int Area()
        {
            return length * width * height;
        }
    }
}