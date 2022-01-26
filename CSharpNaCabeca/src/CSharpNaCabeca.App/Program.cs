using CSharpNaCabeca.App.classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace CSharpNaCabeca.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"#### C# NA CABEÇA - ESCREVER FORMATO CSV CONSOLE E GERAR ARQUIVO EXCEL ####");
            Console.WriteLine();
            Console.WriteLine($@"#### INICIO ####");

            var PATH = $@"C:\repos\git\CSharpNaCabeca\";

            var lista = new List<Registro>();
                lista.Add(new Registro ("Fulano", 1987, "C#"));
                lista.Add(new Registro ("Sicrano", 1991, "C++"));
                lista.Add(new Registro ("Beltrano", 2018, "Nodejs"));

            var infos = lista.Select(i => (string)i);

            if (infos.Any()) 
            {
                foreach (var item in infos)
                {
                    Console.WriteLine(item);
                }

                File.WriteAllLines($@"{PATH}arq_excel.csv", infos);
            }

            Console.WriteLine($@"#### FIM ####");
        }
    }
}
