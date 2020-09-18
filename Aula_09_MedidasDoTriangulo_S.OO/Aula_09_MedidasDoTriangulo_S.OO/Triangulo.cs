using System;

namespace Aula_09_MedidasDoTriangulo_S.OO {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        //calculo da area
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * ( p - A ) * ( p - B ) * ( p - C ));            
        }
    }
}
