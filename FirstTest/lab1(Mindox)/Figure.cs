using lab1_Mindox_.Strategy;

namespace lab1_Mindox_
{
    public class Figure
    {
        private IStrategy strategy; 
         
        public Figure(double radius)
        {
            strategy = new Circle(radius);
        }

        public Figure(double a, double b, double c)
        {
            strategy = new Triangle(a, b, c); 
        }
      
        public double СalculationArea()
        {
            return strategy.СalculationArea();
        }
    }
}
