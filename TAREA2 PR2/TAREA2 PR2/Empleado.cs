using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2_PR2
{
    class Empleado
    {
        //Declaracion de las distintas variables que seran utilizadas 
        //en las clases para crear los empleados

        public string Nombre {get; set;}
        public string Apellido{ get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public string Codigo { get; set; }
        public double PrecioHora { get; set; }
        public int HorasTrabajo { get; set; }
        public double Salario { get; set; }
        public double Bono { get; set; }
        public double SalarioNeto { get; set; }

    }
}
