using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilderMethod();

            ListMethod();

            Console.ReadKey();
        }

        static void StringBuilderMethod()
        {
            Console.WriteLine("----- STRING BUILDER -----");
            Console.WriteLine("***** CASO 001 *****");

            var sb1 = new StringBuilder();
            sb1.Append("PRIMEIRA LINHA" + Environment.NewLine);
            sb1.Append("SEGUNDA LINHA");

            var x = sb1.ToString();

            Console.WriteLine(x);

            Console.WriteLine("***** CASO 002 *****");

            var sb2 = new StringBuilder();
            sb2.Append("PRIMEIRA LINHA" + Environment.NewLine);
            sb2.Append("SEGUNDA LINHA");

            var y = sb2.ToString();

            Console.WriteLine(y);
        }

        static void ListMethod()
        {
            Console.WriteLine("----- LISTA -----");
            Console.WriteLine("***** CASO 001 *****");

            var listaDeErros = new List<string>
            {
                "Erro 01",
                "Erro 02"
            };

            var novaLista = new List<string> { "Os erros foram:" }.Concat(listaDeErros).ToList();

            for (int i = 0; i < novaLista.Count; i++)
            {
                Console.WriteLine($"{i} - {novaLista[i]}");
            }


            Console.WriteLine("***** CASO 002 *****");

            var listaDeErros2 = new List<string>
            {
                "Erro 01",
                "Erro 02"
            };

            listaDeErros2.Insert(0, "Os erros foram:");

            for (int i = 0; i < listaDeErros2.Count; i++)
            {
                Console.WriteLine($"{i} - {listaDeErros2[i]}");
            }

        }


    }
}
