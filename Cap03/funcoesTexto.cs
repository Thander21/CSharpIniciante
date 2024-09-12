using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("-----------Funções de Texto-------------");
            string empresa = "     Microsoft Corporation   ";
            WriteLine("TRIM - retira os espaços em branco antese apos a expressão");
            WriteLine($"Nome com espaços: {empresa}.");
            WriteLine($"Tamanho do Texto com espaços: {empresa.Length}.");
            WriteLine($"Nome sem espaços: {empresa.Trim()}.");
            WriteLine($"Tamanho do Texto sem espaços: {empresa.Trim().Length}.");
            WriteLine($"Maiusculos: {empresa.ToUpper()} e minusculos: {empresa.ToLower()}.");

            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";
            // comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 - nomes iguais");
            else
                WriteLine("1 - nomes diferentes");
            // comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");
            // comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");


        }
    }
}
