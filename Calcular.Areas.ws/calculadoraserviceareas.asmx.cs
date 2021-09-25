using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calcular.Areas.ws
{
    /// <summary>
    /// Descripción breve de calculadoraserviceareas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class calculadoraserviceareas : System.Web.Services.WebService
    {

       [WebMethod]
        public string Bienvenidos()
        {
           return "Calculadora para obtener el area de un Cuadradro, Triangulo y Circulo";
        }

        [WebMethod(Description = "Metodo para obtener el Area del Cuadrado")]
        public decimal Area_de_un_Cuadrado(decimal L)
        {
            Calcular areas = new Calcular();
            return areas.Cuadrado(L);
        }

        [WebMethod(Description = "Metodo para obtener el Area del Triangulo,  SOLO ACEPTA NUMEROS ENTEROS")]
        public double Area_del_Triangulo(int B, int H)
        {
            Calcular areas = new Calcular();
            return areas.Triangulo(B, H);
        }

        [WebMethod(Description = "Metodo para obtener el Area del Circulo,  SOLO ACEPTA NUMEROS ENTEROS")]
        public double Area_del_Circulo(int R)
                {
            Calcular areas = new Calcular();
            return areas.Circulo(R);
        }
    
    }
}