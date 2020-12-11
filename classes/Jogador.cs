using System;

namespace POO_JogadorFutebol.classes
{
    public class Jogador
    {
        public string nome;
        public string posicao;
        public string dataNascimento;
        public int anoNascimento;
        public int anoAtual;
        public string nacionalidade;
        public float altura;
        public float peso;

        public int IdadeJogador(int anoNascimento, int anoAtual){
            int idade = anoAtual - anoNascimento;
            
            return idade;
        }

        public int TempoAposentadoria(int idade, string posicao){
            int tempoAposentadoria;
            switch (posicao)
            {
                case "Defesa":
                tempoAposentadoria = 40 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"Faltam {tempoAposentadoria} anos para o jogador se aposentar");              
                return tempoAposentadoria;
        
                case "Meio-Campo":
                tempoAposentadoria = 38 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"Faltam {tempoAposentadoria} anos para o jogador se aposentar");
                return tempoAposentadoria;
        
                case "Atacante":
                tempoAposentadoria = 35 - IdadeJogador(anoNascimento, anoAtual);
                Console.WriteLine($"Faltam {tempoAposentadoria} anos para o jogador se aposentar");
                return tempoAposentadoria;
        
                default:

                    return 0;
            }
            
            
        }

        public void ImprimirDadosJogador(string nome, string posicao, string dataNascimento, int idade, string nacionalidade, float altura, float peso){
            idade = 2020 - anoNascimento; 
            Console.WriteLine($"Nome do Jogador: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Posição: {posicao}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento}");
            Console.WriteLine($"Nascionalidade: {nacionalidade}");

        }
        
    }
}