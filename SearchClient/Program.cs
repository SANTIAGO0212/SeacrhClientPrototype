using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchClient
{
    public class Program
    {
        static List<Cliente> cliente = new List<Cliente>
        {
            new Cliente { Id = 1, User = "Santiago Jimenez"},
            new Cliente { Id = 2, User = "Harold Montejo " },
            new Cliente { Id = 3, User = "Alejandro Ruiz" },
            new Cliente { Id = 4, User = "Stiven Santiago" }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Buscar Cliente");
            Console.Write("Ingrese el nombre del cliente: ");
            string searchTerm = Console.ReadLine().ToLower();

            List<Cliente> resultados = BuscarClientePorNombre(searchTerm);

            MostrarResultados(resultados);

            Console.ReadLine();
        }
        static List<Cliente> BuscarClientePorNombre(string searchTerm)
        {
            List<Cliente> resultados = cliente.FindAll(cliente =>
                cliente.User.ToLower().Contains(searchTerm)
            );

            return resultados;
        }
        static void MostrarResultados(List<Cliente> resultados)
        {
            Console.WriteLine("\nResultados:");
            if (resultados.Count > 0)
            {
                foreach (var cliente in resultados)
                {
                    Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.User}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron resultados.");
            }
        }
    }
}
