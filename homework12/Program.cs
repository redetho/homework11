using System;
using System.Collections.Generic;

namespace homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma lista de strings
            List<string> list = new List<string>();
            //adicionando elementos
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");
            //Realizando um loop de leitura dos elementos inseridos
            list.Insert(2, "Lucas");

            //Realiza um loop de leitura dos elementos inseridos
            foreach (string obj in list)
            {//Contando quantos elementos tem na minha lista
                Console.WriteLine("Quantidade de elementos na Lista: " + list.Count);
                //Encontra o primeiro elemento que inicia com a letra A, com uma função lambda
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Encontrar o último elemento que inicia com a letra A, com uma função lambda
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Buscar elementos pela sua posição
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("Primeira Posição de 'A': " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Última Posição de 'A': " + pos2);
                //Busca todos os elementos com tamanho igual a 5 caracteres
                List<string> list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("-------------------------------");
                foreach (string obje in list2)
                {
                    Console.WriteLine(obje);
                }
                //Remover elementos da lista
                list.Remove("Andre");
                Console.WriteLine("============");
                foreach (string ob in list)
                {
                    Console.WriteLine(ob);
                }
                //Remover determinado elemento da lista
                list.RemoveAll(x => x[0] == 'W');
                Console.WriteLine("+++++++++++++++++++");
                foreach (string obje in list)
                {
                    Console.WriteLine(obje);
                }
                //Remover elemento de determinada posição lista
                list.RemoveAt(3);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                foreach (string obje in list)
                {
                    Console.WriteLine(obje);
                }
                //Remover elementos da lista a partir da posição e quantos elementos
                list.RemoveRange(1, 2);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                foreach (string obje in list)
                {
                    Console.WriteLine(obje);
                }
            }
        }
    }
}
