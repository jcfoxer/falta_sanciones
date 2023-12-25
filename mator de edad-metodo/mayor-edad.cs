using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//este se agrego al hacer clik en soliconar problemas con el codigo 
//se tiene que agrehar winsdow forms 

namespace mator_de_edad_metodo
{
    class mayor_edad
    {

        int resultado ;
        public int mayor(int edad){

            
            if (edad>=18)
            {

                MessageBox.Show("usted es mayor de edad");

            }
            else
            {
                MessageBox.Show("usted es menor de edad");


            }


            return resultado;
            }




    }
}
