using System;

namespace ConsoleClassPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Thiago";
            pessoa.idade = 32;

            Pessoa pessoaSilvia = new Pessoa();
            pessoaSilvia.nome = "Silvia";
            pessoaSilvia.idade = 23;

            pessoa.Acenar(pessoaSilvia);
            pessoaSilvia.Idade();
            pessoa.Idade();
            pessoa.PerguntaIdadePara(pessoaSilvia);
        }
    }
}
