using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calcular.Areas.ws
{
    public class Calcular
    {
        public decimal Cuadrado(decimal L)
        {
            decimal result = L * L;
            return result;
        }

        public double Triangulo(int B, int H)
        {
            var result = (B * H) / 2;
            return result;
        }

        public double Circulo(int R)
        {
            var result = Math.PI * Math.Pow(R, 2);
            return result;
        }
    }
}