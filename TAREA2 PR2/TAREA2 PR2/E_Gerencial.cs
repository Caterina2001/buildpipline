using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2_PR2
{
    class E_Gerencial: Empleado //Hereda las variables de la clase Empleado
    {
        private static E_Gerencial instancia;

        Random aleatorio = new Random();  //Meotodo para obtener numeros aleatorios

        private E_Gerencial()
        {
            //Ingreso de los diferentes datos a las variables correspondientes
            Console.Write("REGISTRO EMPLEADO GERENCIAL");
            Console.Write("\nIngrese nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            Apellido = Console.ReadLine();

            Console.Write("Ingrese la cedula de identidad: ");
            Cedula = Console.ReadLine();

            Console.Write("Ingrese el correo: ");
            Correo = Console.ReadLine();

            Console.Write("Ingrese el telefono: ");
            Telefono = Console.ReadLine();

            Console.Write("Departamento al que pertenece: ");
            Departamento = Console.ReadLine();

            Console.Write("Cargo asignado: ");
            Cargo = Console.ReadLine();

            int numrandom = aleatorio.Next(5000, 8000);  //Uso del Random con rango de num. a elegir
            Codigo = Departamento[0].ToString() + Departamento[1].ToString() + Departamento[2].ToString() + numrandom; //Obtencion de las 3 primeras letras del depto.

            Console.Write("Precio asignado por hora: ");
            PrecioHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Horas a trabajar: ");
            HorasTrabajo = int.Parse(Console.ReadLine());

            Salario = PrecioHora * HorasTrabajo; //Salario sin el bono
            Bono = Salario * 0.50; // Bono adicional
            SalarioNeto = Salario + Bono; //Salario con bono incluido


        }
        public static E_Gerencial Instancia()
        {
            
            if (instancia == null)
            {
                instancia = new E_Gerencial();
            }
            return instancia;
            
        }
    }
}
