using System;

using System.Collections.Generic;

namespace AppListas
{
    class MainClass
    {
        enum Turno
        {
            Manha,
            Tarde,
            Noite
        }

        enum Meses
        {
            Jan = 1,
            Fev,
            Mai = 5,
            Jun
        }

        public static void Main(string[] args)
        {
            // int[] primos = { 1, 2, 3, 5, 7, 11, 13, 17 };
            // Console.WriteLine(Meses.Mai);
            // Console.WriteLine( (int) Meses.Mai );

            List<string> carros = new List<string> { "Uno", "Doblo", "Toro" };
            carros.Add("Fusca");

            List<Carro> objCarros = new List<Carro>();

            Carro c1 = new Carro("BMW");
            objCarros.Add(c1);

            objCarros.Add( new Carro("Ferrari") );

            Console.WriteLine( "Total de Carros: " + objCarros.Count );

            foreach( string car in carros)
            {
                Console.WriteLine( car );
            }

            imprimirCarros(objCarros);

            objCarros.Insert(1, new Carro("Porche") );
            imprimirCarros(objCarros);

            objCarros.Remove(c1);
            imprimirCarros(objCarros);

            objCarros.RemoveAt(1);
            imprimirCarros(objCarros);
            objCarros.Add(c1);

            if( objCarros.Contains( c1 ))
            {
                Console.WriteLine("O carro: " + c1.nome + " está na lista");
            }
            else
            {
                Console.WriteLine("O carro: " + c1.nome + " não está na lista");
            }

        }

        public static void imprimirCarros( List<Carro> lista)
        {
            foreach (Carro car in lista)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("-------------------");
        }
    }
}