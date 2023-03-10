namespace Shape.Models
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return (Base * Height) / 2;
        } 
    }
}
