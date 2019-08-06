using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            cls_Biblioteca clsb = new cls_Biblioteca();
            Console.WriteLine("                 _____Numero de Registros_____");
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            clsb.Registro(a);
            clsb.Imprimir();
            Console.ReadLine();
            
        }
    }
}
