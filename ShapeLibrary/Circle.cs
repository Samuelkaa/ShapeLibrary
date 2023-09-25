namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(ShapeTypes shapeType, double radius) : base(shapeType)
        {
            Radius = radius;
        }

        public override double Square()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }
    }
}
