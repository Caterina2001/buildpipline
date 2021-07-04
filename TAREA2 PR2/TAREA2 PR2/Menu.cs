using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2_PR2
{
    class Menu
    {
        public static bool Verificar = false;
        static List<Empleado> ListaEmpleado = new List<Empleado>();  //Creacion de la lista

        public void menues()
        {

            int i = 0; //Variable del do while

            do
            {
                Console.WriteLine("\n ---------------MENU PRINCIPAL----------------" + //Menu principal
                "\n 1- Crear Empleado" +
                "\n 2- Ver Empleado" +
                "\n 3- Cerrar Menu");
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (menu == 1)  //Esta opcion permite crear un nuevo empleado
                {
                    Console.WriteLine("Que tipo de empleado?" +
                    "\n 1- Empleado Gerencial" +
                    "\n 2- Empleado Administrativo" +
                    "\n 3- Empleado Operativo");

                    String creacion = Console.ReadLine();  //Se dirige a la Factoria a elegir el tipo de emepleado y pregunta para obtener datos

                    if (creacion == "1")
                    {
                        if (Verificar == false)
                        {
                            ListaEmpleado.Add(Factoria.Nuevo("1")); //Crea un empleado gerencial
                            Verificar = true;
                        }
                        else
                        {
                            Console.WriteLine("Ya hay un gerente registrado");
                            Console.ReadKey();
                        }
                    }
                    if (creacion == "2")
                    {
                        ListaEmpleado.Add(Factoria.Nuevo("2"));  //Se añade el empleado a la lista
                    }
                    if (creacion == "3")
                    {
                        ListaEmpleado.Add(Factoria.Nuevo("3"));  //Se añade el empleado a la lista
                    }
                    Console.Clear();  //Limpiar la consola 
                }
                else if (menu == 2)
                {
                    int l = 1;
                    foreach (Empleado trabajador in ListaEmpleado)  //Se visualiza cada empleado que este en la lista
                    {
                        Console.WriteLine("------------EMPLEADO "+(l)+ " REGISTRADO------------" +  //Imprime los datos obtenidos
                        "\n Nombre: " + trabajador.Nombre +
                        "\n Apellido: " + trabajador.Apellido +
                        "\n Cedula: " + trabajador.Cedula +
                        "\n Correo: " + trabajador.Correo +
                        "\n Telefono: " + trabajador.Telefono +
                        "\n Departamento: " + trabajador.Departamento +
                        "\n Cargo: " + trabajador.Cargo +
                        "\n Codigo: " + trabajador.Codigo);
                        l = l + 1;
                    }

                    Console.WriteLine("----------MENU OPCIONES EMPLEADO------------" +  //SubMenu para acceder a los demas metodos del empleado
                        "\n 1- Cobrar" +
                        "\n 2- Recibo de Pago");
                   
                    int menu2 = Convert.ToInt32(Console.ReadLine());  //Nueva condicion dependiendo de la eleccion del usario
                    Console.Clear();

                    if (menu2 == 1)
                    {
                        int x = 1;
                        foreach (Empleado trabajador in ListaEmpleado)  //Por cada empleado en la lista, imprime el sueldo
                        {
                            Console.WriteLine("=================== "+(x)+" =====================" +
                                "\n Gracias al bono, este mes va a cobrar: " + trabajador.SalarioNeto);
                            x = x + 1;
                        }
                    }
                    if (menu2 == 2)

                    {
                        int n = 1;
                        foreach (Empleado trabajador in ListaEmpleado)  //Por cada empleado en lista, imprime un recibo de pago
                        {   
                            Console.WriteLine("--------------RECIBO DE PAGO " + (n) + "----------------" +
                                "\n Nombre: " + trabajador.Nombre +
                                "\n Codigo: " + trabajador.Codigo +
                                "\n Departamento: " + trabajador.Departamento +
                                "\n Precio asignado por hora: " + trabajador.PrecioHora +
                                "\n Horas trabajadas: " + trabajador.HorasTrabajo +
                                "\n El salario este mes es de : " + trabajador.SalarioNeto +
                                "\n PAGO EFECTUADO CORRECTAMENTE AL EMPLEADO...");
                            n = n + 1;
                        }
                    }

                }
                else if (menu == 3)  //Opcion para cerrar rograma
                {
                    break;
                }


            } while (i != 3);  //Acaba la condicion y cierra la consola
        }

    }
}




        