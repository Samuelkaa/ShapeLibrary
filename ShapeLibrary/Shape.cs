namespace ShapeLibrary
{
    public abstract class Shape
    {
        private ShapeTypes ShapeType { get; set; }

        public Shape(ShapeTypes shapeType)
        {
            ShapeType = shapeType;
        }

        public abstract double Square();


    }
}