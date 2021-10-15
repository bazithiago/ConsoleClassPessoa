using System;
namespace ConsoleClassPessoa
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string rg;

        public void Acenar(Pessoa pessoa)
        {
            Console.WriteLine($"{this.nome} acenou para {pessoa.nome}");
        }

        public void PerguntaIdadePara(Pessoa pessoa) 
        {
            Console.WriteLine($"Olá, {pessoa.nome}, qual sua idade?");
            pessoa.Idade();
        }
        public void Idade()
        {
            Console.WriteLine($"Eu, {this.nome}, tenho {this.idade}");
        }
    }
}

