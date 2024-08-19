namespace Circle_Objects;

internal class Circle
{
        //property
        private double Radius { get; set; }
        //constructor 
        public Circle(double _radius)
        {
                Radius = _radius;
        }
        // methods
        public double CalculateDiameter()
        {
                return Radius * 2;
        }
        public double CalculateCircumference()
        {
                return Radius * Math.PI * 2;
        }
        public double CalculateArea()
        {
                return Radius * Radius * Math.PI;
        }
        public void Grow()
        {
                Radius *= 2;
        }
        public double GetRadius()
        {
                return Radius;
        }
}