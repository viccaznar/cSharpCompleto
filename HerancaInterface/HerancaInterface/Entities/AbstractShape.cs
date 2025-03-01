using Course.Model.Enums;
using Course.Entities;

namespace Course.Entities{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
