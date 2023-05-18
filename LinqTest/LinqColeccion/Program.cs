// See https://aka.ms/new-console-template for more information
using LinqColeccion;
using System.Linq;

// Seleccion numeros pares

int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine("A continuacion te mostramos los numeros pares que existen en el arreglo: ");

//Sin LINQ
/*List<int> numerosPares = new List<int>();
foreach (int numero in numeros)
{
    if(numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}*/

//Con LINQ
//IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;

//Impresión numeros pares

/*foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}*/

//Ejemplo control Alumno Objetos
ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerAlumnosPorCarrera(2);
