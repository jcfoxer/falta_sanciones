using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_basicas_con_parametros
{
    class clase_operaciones
    {

        int resultado = 0;//solo esto emglovba a los demas 

        public int suma(int num1, int num2)
        {
            resultado = num1 + num2;
            return resultado;
        }

        public int resta(int num1, int num2)
        {
            resultado = num1 - num2;
            return resultado;

        }
        public int producto(int num1, int num2)
        {
            resultado = num1 * num2;
            return resultado;

        }



    }
}
