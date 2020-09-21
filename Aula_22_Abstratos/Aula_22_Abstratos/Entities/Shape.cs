using Aula_22_Abstratos.Entities.Enums;

namespace Aula_22_Abstratos.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }
        public Color Color { get; } //Foi preciso adicionar para remover o erro

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
