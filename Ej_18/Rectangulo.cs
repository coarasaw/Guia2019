using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometira
{
    public class Rectangulo
    {
        private float perimetro;
        private float area;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

        public float Area()
        {
            int baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
            int alt = Math.Abs(vertice1.GetY() - vertice3.GetY());
            area = (float)baseRectangulo * alt;

            return area;
        }

        public float Perimetro()
        {
            int baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
            int alt = Math.Abs(vertice1.GetY() - vertice3.GetY());
            perimetro = (float)((baseRectangulo + alt) * 2);

            return perimetro;
        }

    }
}
