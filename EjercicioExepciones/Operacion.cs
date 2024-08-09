using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExepciones
{
    public class Operacion
    {
        public double Suma(double numUno ,double numDos)
        {

            double Resultado = numUno + numDos;
            return Resultado;
        }

        public double Resta(double numUno, double numDos)
        {
            double Resultado = numUno - numDos;
            return Resultado;
        }

        public double Multiplicacion(double numUno, double numDos) 
        {
            double Resultado = numUno * numDos;
            return Resultado;
        }

        public double Division(double numUno, double numDos)  
        {
            double Resultado = numUno / numDos;
            return Resultado;
        }
    }
}
