using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2_PR2
{
    class Factoria
    {     
        //Metodo Factory para crear distintos tipos de empleados desde una sola clase
        //En cualquier momento se puede agregar otro nuevo empleado mas facil

        static public Empleado Nuevo(String creacion) 

        {
            if (creacion == "1")
            {
                return E_Gerencial.Instancia();               
            }
            if (creacion == "2")
            {
                return new E_Administrativo();  //Crea un empleado administrativo
            }
            if (creacion == "3")
            {
                return new E_Operativo();  //Crea un empleado operativo
            }
            else
            {
                return null;
            }
        }
    }
}
