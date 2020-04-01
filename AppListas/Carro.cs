using System;
namespace AppListas
{
    public class Carro
    {
        public string nome;

        public Carro(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome;
        }

    }
}
