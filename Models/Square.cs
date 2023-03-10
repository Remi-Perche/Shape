namespace Shape.Models
{
    public class Square : Shape
    {
        public double Coast { get; set; }
        public override double Area()
        {
            return Coast * Coast;
        }
    }
}
