using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        //1.-SUMA
        [WebMethod(Description = "Suma dos números")]
        public double Suma(double n1, double n2)
        {
            double resultado = n1 + n2;
            return resultado;
        }

        //2.-RESTA
        [WebMethod(Description = "Resta dos números")]
        public double Resta(double n1, double n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }

        //3.-MULTIPLICACION
        [WebMethod(Description = "Multiplica dos números")]
        public double Multiplicacion(double n1, double n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }

        //4.-DIVISION
        [WebMethod(Description = "Divide dos números")]
        public double Division(double n1, double n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }

        //5.-RAIZ
        [WebMethod(Description = "Raiz n del número m (indice - radicando)")]
        public double Raiz(double i, double n)
        {
            return Math.Pow(n, 1.0 / i);
        }

        //6.-POTENCIA
        [WebMethod(Description = "n a la potencia m (base - exponente)")]
        public double Potencia(double b, double e)
        {
            return Math.Pow(b,e);
        }

        //7.-INVERSA
        [WebMethod(Description = "Inversa de un número")]
        public double Inversa(double n)
        {
            return 1/n;
        }

        //8.-FACTORIAL
        [WebMethod(Description = "Factorial de un número")]
        public double Factorial(double n)
        {
            double resultado = n;
            if (n == 0 || n == 1)
                return 1;
            while (n > 1)
            {
                n--;
                resultado *= n;
            }
            return resultado;
        }

        //9.-LOGARITMO
        [WebMethod(Description = "Devuelve el logritmo natural de un número")]
        public double Logaritmo(double n)
        {
            return Math.Log(n);
        }

        //10.-VALOR ABSOLUTO
        [WebMethod(Description = "Devuelve el valor absoluto de un número")]
        public double ValorAbsoluto(double n)
        {
            return Math.Abs(n);
        }
    }
}
