using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class cls_Biblioteca
    {
        #region Propiedades
        public string NombreLibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Paginas { get; set; }
        public string Genero { get; set; }
        #endregion

        #region Atributos
        public List<cls_Biblioteca> Libros = new List<cls_Biblioteca>(); //Creacion de lista
        #endregion

        #region RegistroLibro
        public void Registro(int a)
        {
            for (int i = 0; i < a; i++)
            {
                cls_Biblioteca b = new cls_Biblioteca(); //Consumismos la clase para poder utilizar la lista
                Console.WriteLine("                 _____Registro Libro_____");
                Console.WriteLine();
                Console.WriteLine("Nombre Libro");
                b.NombreLibro = Console.ReadLine();
                Console.WriteLine("Autor Libro");
                b.Autor = Console.ReadLine();
                Console.WriteLine("Editorial");
                b.Editorial = Console.ReadLine();
                Console.WriteLine("Paginas");
                b.Paginas = int.Parse(Console.ReadLine());
                Console.WriteLine("Genero");
                b.Genero = Console.ReadLine();

                Libros.Add(b); //Guarda los datos Registrados en el ciclo for() en la lista 

                Console.Clear();
            }
        }
        public void Imprimir()
        {
            foreach (var b in Libros )
            {
                Console.WriteLine("                 _____Datos libro_____");
                Console.WriteLine();
                Console.WriteLine($"Nombre:     {b.NombreLibro}");
                Console.WriteLine($"Autor:      {b.Autor}");
                Console.WriteLine($"Editorial:  {b.Editorial}");
                Console.WriteLine($"Paginas:    {b.Paginas}");
                Console.WriteLine($"Genero:     {b.Genero}");
                Console.WriteLine();
                Console.WriteLine($"            >>> Libros Registrados <<<");
            }
        }
        #endregion
    }
}
