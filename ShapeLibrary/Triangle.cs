namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        private double SideA {  get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(ShapeTypes shapeType, double sideA, double sideB, double sideC) : base(shapeType)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Сторона не может быть равна меньше нуля");
            }
            else if (sideA >= (sideB + sideC) || sideB >= (sideA + sideC) || sideC >= (sideA + sideB))
            {
                throw new ArgumentException("Такого треугольника не существует.");
            }
            else
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }

        public override double Square()
        {
            double p = (SideA + SideB + SideC) / 2;
            double square = Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 1);
            return square;
        }

        public bool isRectangular()
        {
            bool isRect = (
                Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2) ||
                Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2) ||
                Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2)
                );
            return isRect;
        }
    }
}
