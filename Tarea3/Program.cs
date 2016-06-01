using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 6;
        static int contaMenoresEdad = 0;
        static int contaJovenes = 0;
        static int contaAdultos = 0;
        static int contaHombres = 0;
        static int contaMujeres = 0;
               
        struct Estudiante
        {
            public int codigo;
            public string nombre;
            public int edad;
            public string sexo;
        };

        static Estudiante[] Estudiantes;

        static void agregarEstudiantes() {
            int r = 0;
            while(r != 1){
                Console.Clear();
                if (i < Estudiantes.Length)
                {
                    Console.WriteLine("Universidad UH");
                    Console.WriteLine("Ingreso de estudiantes.             ");
                    Console.Write("Digite el codigo del estudiante:                  ");
                    Estudiantes[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    Estudiantes[i].nombre = Console.ReadLine();
                    Console.Write("Digite la edad del estudiante:     ");
                    Estudiantes[i].edad = int.Parse(Console.ReadLine());
                    Console.Write("Digite el sexo del estudiante:    ");
                    Estudiantes[i].sexo = Console.ReadLine();
                    if (Estudiantes[i].sexo == "M" || Estudiantes[i].sexo == "m")
                    {
                        contaHombres = contaHombres + 1;
                    }
                    else if (Estudiantes[i].sexo == "F" || Estudiantes[i].sexo == "f")
                    {
                        contaMujeres = contaMujeres + 1;
                    }
                    else {
                        Console.WriteLine("Verifique el sexo, solo puede ser M/m(masculino) o F/f(femenino)");
                    }

                    if (Estudiantes[i].edad <= 18)
                    {
                        contaMenoresEdad = contaMenoresEdad + 1;
                    }
                    else if (Estudiantes[i].edad >= 19 && Estudiantes[i].edad <= 29)
                    {
                        contaJovenes = contaJovenes + 1;
                    }
                    else {
                        contaAdultos = contaAdultos + 1;
                    }
                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else {
                    Console.WriteLine("Registro de estudiantes lleno..");
                    r = 1;
                    Console.ReadKey(); 
                }
            }
            
        }

        static void modificacionDeEstudiantes() {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while(r != 1){
                Console.WriteLine("Universidad UH");
                Console.WriteLine("Modificacion de estudiantes.             ");
                Console.WriteLine("Digite el codigo del estudiante a modificar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < Estudiantes.Length ;i++ )
                {
                    if(codigo == Estudiantes[i].codigo){
                        reg = i + 1;
                        Console.Write("Digite el nombre del estudiante:    ");
                        Estudiantes[i].nombre = Console.ReadLine();
                        Console.Write("Digite la edad del estudiante:     ");
                        Estudiantes[i].edad = int.Parse(Console.ReadLine());
                        Console.Write("Digite el sexo del estudiante:    ");
                        Estudiantes[i].sexo = Console.ReadLine();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                else {
                    Console.WriteLine("Desea modificar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());  
                }
            }
        }

        static void borrarEstudiantes() {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while(r != 1){
                Console.Clear();
                Console.WriteLine("Cual estudiante desea eliminar.           ");
                Console.WriteLine("Digite el codigo del estudiante a eliminar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < Estudiantes.Length; i++)
                {
                    if (codigo == Estudiantes[i].codigo)
                    {
                        reg = i + 1;
                        Estudiantes[i].codigo = 0;
                        Estudiantes[i].nombre = "";
                        Estudiantes[i].sexo = "";
                        Estudiantes[i].edad = 0;
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Estudiante eliminado");
                Console.WriteLine("Desea eliminar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void busquedaDeEstudiantes() {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();                
                Console.WriteLine("Búsquedad de estudiantes.           ");
                Console.WriteLine("Digite el codigo del estudiante a buscar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < Estudiantes.Length; i++)
                {
                    if (codigo == Estudiantes[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + Estudiantes[i].codigo);
                        Console.WriteLine("Nombre:   " + Estudiantes[i].nombre);
                        Console.WriteLine("Edad:     " + Estudiantes[i].edad);
                        Console.WriteLine("Sexo:   " + Estudiantes[i].sexo);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            } 
        }

        static void listaDeEstudiantes() {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("Listado Estudiantil");
            Console.WriteLine("=================================");
            Console.WriteLine("Universidad UH");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Reg   Codigo   Nombre       Sexo   Edad");
            for (i = 0; i < Estudiantes.Length ;i++)
            {
                reg = i + 1;
                Console.WriteLine(reg + "/t/t" + Estudiantes[i].codigo + "        " + 
                    Estudiantes[i].nombre + "       " + Estudiantes[i].sexo + 
                    "      " + Estudiantes[i].edad);
            }
            Console.WriteLine("=================================");
            Console.ReadKey();
        }

        static void clasificacionDeEstudiantes() {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("Informe Clasificacion estudiantil UH");
            Console.WriteLine("=================================");
            Console.WriteLine("Clasificacion por Edad   ||   Clasificacion por Genero");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Menores de edad : " + contaMenoresEdad + " || " + "Hombres: " + contaHombres);
            Console.WriteLine("Jovenes : " + contaJovenes + " || " + "Mujeres: " + contaMujeres);
            Console.WriteLine("Adultos : " + contaAdultos + " || ");
            Console.WriteLine("=================================");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Estudiantes = new Estudiante[size];           

            do{
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. Ingreso de estudiantes.");
                Console.WriteLine("2. Modificación de estudiantes.");
                Console.WriteLine("3. Borrado de estudiantes.");
                Console.WriteLine("4. Búsquedad de estudiantes.");
                Console.WriteLine("5. Listado de estudiantes.");
                Console.WriteLine("6. Informe clasificacion de estudiantes.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            agregarEstudiantes();
                            break;
                        }
                    case 2:
                        {
                            modificacionDeEstudiantes();
                            break;
                        }
                    case 3:
                        {
                            borrarEstudiantes();
                            break;
                        }
                    case 4:
                        {
                            busquedaDeEstudiantes();
                            break;
                        }
                    case 5:
                        {
                            listaDeEstudiantes();
                            break;
                        }
                    case 6:
                        {
                            clasificacionDeEstudiantes();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }                
                }
            }while (option != 7);        
        }
    }
}
