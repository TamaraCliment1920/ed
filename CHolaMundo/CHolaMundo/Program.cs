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
        }
    }
}
