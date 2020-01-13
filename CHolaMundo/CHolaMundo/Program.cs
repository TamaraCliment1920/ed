using System;

namespace CHolaMundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Introduce tu nombre: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Hola " +  nombre);

            Console.WriteLine("Dime el primer numero:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu edad en 2021 es  " + ++edad);
        }
    }
}
