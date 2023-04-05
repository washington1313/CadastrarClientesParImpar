using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Clientes_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesClientes = new string[6];
            int Contador = 0;

            while (Contador < nomesClientes.Length) 
            {
                Console.WriteLine("Digite o Nome do Cliente;");
                nomesClientes[Contador] = Console.ReadLine();
                Contador++;

                Console.Clear();            
            }

            int Contador2 = 0;
            while (Contador2 < nomesClientes.Length) 
            {
                if (Contador2 % 2 == 0)
                {
                    Console.WriteLine(nomesClientes[Contador2]);                  
                }
                Contador2++;
            }

            int Contador3 = 0;
            while (Contador3 < nomesClientes.Length)
            {
                if (Contador3 % 2 != 0)
                {
                    Console.WriteLine(nomesClientes[Contador3]);
                }
                Contador3++;
            }
            Console.ReadKey();
        }
    }
}
