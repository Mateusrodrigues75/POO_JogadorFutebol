using System;
using POO_JogadorFutebol.classes;

namespace POO_JogadorFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador1 = new Jogador();

            Console.WriteLine("Digite o nome do Jogador: ");
            jogador1.nome = Console.ReadLine();
            
            Console.WriteLine("Digite em qual Posição o jogador joga: \nDefesa, Meio-Campo ou Atacante");
            jogador1.posicao = Console.ReadLine();
            
            Console.WriteLine("Digite a data de Nascimento do jogador: ");
            jogador1.dataNascimento = Console.ReadLine();
            
            Console.WriteLine("Digite o ano do Nascimento do Jogador: ");
            jogador1.anoNascimento = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Ano atual: ");
            jogador1.anoAtual = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nacionalidade do Jogador: ");
            jogador1.nacionalidade = Console.ReadLine();
            
            Console.WriteLine("Digite a altura do Jogador: \nObs: em Metros");
            jogador1.altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o peso do Jogador: \nObs: em Kilogramas");
            jogador1.peso = float.Parse(Console.ReadLine());

            jogador1.IdadeJogador(jogador1.anoNascimento, jogador1.anoAtual);
            
            Console.Clear();
            jogador1.ImprimirDadosJogador(jogador1.nome,jogador1.posicao, jogador1.dataNascimento, jogador1.IdadeJogador(jogador1.anoNascimento,jogador1.anoAtual), jogador1.nacionalidade, jogador1.altura, jogador1.peso);

            jogador1.TempoAposentadoria(jogador1.IdadeJogador(jogador1.anoNascimento, jogador1.anoAtual), jogador1.posicao);
        }
    }
}
