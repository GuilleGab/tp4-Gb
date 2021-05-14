using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4_Gb
{
    public class Persona
    {
        private int dni;
        private string dni1;
        private string nombreApellido;
        private string domicilio;
        private int telefono;
        private string telefono1;
        private string email;
        public string actividad;
        private string linea;
        public int[] documentos = new int[100];
        public string[,] Persons;
        public int filas = 0;



        public void Matriz()
        {
            Persons = new string[100, 6];
        }



        public void CargaPersona()
        {
            Console.WriteLine("Ingrese el dni de la persona");
            linea = Console.ReadLine();
            dni1 = linea;
            dni = int.Parse(linea);
            Console.WriteLine("Ingrese el nombre y apellido de la persona");
            nombreApellido = Console.ReadLine();
            Console.WriteLine("Ingrese el domicilio de la persona");
            domicilio = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono de la persona");
            linea = Console.ReadLine();
            telefono1 = linea;
            telefono = int.Parse(linea);
            Console.WriteLine("Ingrese el email de la persona");
            email = Console.ReadLine();
            Console.WriteLine("Ingrese la actividad de la persona");
            actividad = Console.ReadLine();

            for (int i = filas; i < (filas + 1); i++)
            {
                for (int f = 0; f < 6; f++)
                {
                    switch (f)
                    {
                        case 0:
                            Persons[i, f] = dni1;
                            documentos[i] = dni;
                            break;
                        case 1:
                            Persons[i, f] = nombreApellido;
                            break;
                        case 2:
                            Persons[i, f] = domicilio;
                            break;
                        case 3:
                            Persons[i, f] = telefono1;
                            break;
                        case 4:
                            Persons[i, f] = email;
                            break;
                        case 5:
                            Persons[i, f] = actividad;
                            break;
                        default:
                            break;
                    }
                }
            }

            filas++;


        }

        public int verificarExistencia(int docu)
        {
            int bandera = 0;
            for (int i = 0; i < documentos.Length; i++)
            {
                if (docu == documentos[i])
                {
                    bandera = 1;
                }

            }
            return bandera;
        }


    }

    internal class Actividad
    {
        private string area;
        public string actividadAutorizada;
        public int Bandera = 0;
        public string actividadComparar;
        string[] autoActi = new string[50];
        public int bande1;
        public int bande2;
        public string texto;
        public int documento;
        public string Activity;




        public void Actiauto()
        {
            autoActi[0] = "enfermeria";
            autoActi[1] = "bombero";
            autoActi[2] = "medico";
            autoActi[3] = "militar";
            autoActi[4] = "fuerza de seguridad";
            autoActi[5] = "gastronomico";
            autoActi[6] = "almacen";
            autoActi[7] = "supermercado";
            autoActi[8] = "educacion";
        }


        public int verificarActividad(string acti)
        {
            int bandera = 0;


            for (int i = 0; i < Actiauto.Length; i++)
            {
                if (acti == autoActi[i])
                {
                    bandera = 1;
                }
            }
            return bandera;
        }


        public void autorizarIngreso()
        {
            Console.WriteLine("Ingrese el dni de la persona");
            texto = Console.ReadLine();
            documento = int.Parse(texto);
            Persona persona = new Persona();
            bande1 = persona.verificarExistencia(documento);
            if (bande1 == 1)
            {
                Console.WriteLine("La persona esta autorizada a ingresar");
            }
            else
            {
                Console.WriteLine("Ingrese la actividad de la persona");
                Activity = Console.ReadLine();
                bande2 = verificarActividad(Activity);
                if (bande2 == 1)
                {
                    Console.WriteLine("ingrese los datos de la persona para cargarla al sistema");
                    persona.CargaPersona();
                    Console.WriteLine("La persona esta autorizada a ingresar");
                }
                else
                {
                    Console.WriteLine("La persona no esta autorizada a ingresar");
                }
            }




        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Actividad actividad = new Actividad();
                Console.WriteLine("ingrese los datos de la persona a verificar");
                actividad.Actiauto();
                actividad.autorizarIngreso();
                Console.ReadKey();




            }

        }
}
