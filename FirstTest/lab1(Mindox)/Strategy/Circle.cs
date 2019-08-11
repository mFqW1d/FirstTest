using System;

namespace lab1_Mindox_.Strategy
{
     class Circle : IStrategy
     {
        private double _radius; 

        public Circle(double radius)
        {
            _radius = radius; 
        }

        public double СalculationArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return Math.Round(area, 3);
        } 
        
     }
}
