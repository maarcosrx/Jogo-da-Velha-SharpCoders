namespace JogoDaVelha {
    public class Program {


        static void Menu() {
            Console.WriteLine("-------------------------BEM VINDO AO JOGO DA VELHA-------------------------");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("Novo Jogo-----------------(1)");
            Console.WriteLine("Ver pontuação-------------(2)");
            Console.WriteLine("Sair do jogo--------------(0)");
        }



        public static void Main(string[] args) {

            string[,] posicoes = new string[3, 3];
            int pontuacao;
            int quantidadeJogadas = 0;
            int jogador = 0;
            int pontuacaoJogador1 = 0;
            int pontuacaoJogador2 = 0;
            int velha = 0;
            int opcao = 1;
            Console.Write("Digite o nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();
            Console.WriteLine("Você jogará com X");
            Console.Write("Digite o nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();
            Console.WriteLine("Você jogará com O");

            Console.WriteLine("           INSTRUCAO DO JOGO \n" +
                         "* O primeiro jogador ficara com  X \n" +
                         "* O segundo jogador ficara com  O \n" +
                         "* Digite a localizacao que sera colocado \n" +
                         "* Digite apenas o numero do local que deseja jogar \n" +

                "              1   4   7  \n" +
                "             ---│---│--- \n" +
                "              2   5   8  \n" +
                "             ---│---│--- \n" +
                "              3   6   9  \n" +
                "Vez do jogador 1 \n");

            do {
                do {
                    pontuacao = 0;
                    int l = 0;
                    int c = 0;
                    int number = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("    GUIA \n" +
                    "      1   4   7  \n" +
                    "     ---│---│--- \n" +
                    "      2   5   8  \n" +
                    "     ---│---│--- \n" +
                    "      3   6   9  \n");

                    if (jogador % 2 == 1) {
                        Console.WriteLine();
                        Console.WriteLine($"Vez Jogador {jogador1}");
                    } else {
                        Console.WriteLine();
                        Console.WriteLine($"Vez Jogador {jogador2}");
                    }

                    if (number >= 1 && number < 4) {
                        l = number - 1;
                        c = 0;
                    }
                    if (number >= 4 && number < 7) {
                        l = number - 4;
                        c = 1;
                    }
                    if (number >= 7 && number < 10) {
                        l = number - 7;
                        c = 2;
                    }

                    if (l < 0 || l > 2 || c < 0 || c > 2 || posicoes[l, c] == "X" || posicoes[l, c] == "O") {
                        Console.WriteLine("Posicao Invalida , Tente outra..");
                        jogador--;
                        quantidadeJogadas--;
                    }

                    jogador++;

                    if (jogador % 2 == 1) {
                        posicoes[l, c] = "X";
                    } else {
                        posicoes[l, c] = "O";
                    }

                    string temp = posicoes[l, c];

                    for (l = 0; l <= 2; l++) {
                        for (c = 0; c <= 2; c++) {
                            if (posicoes[l, c] == null) {
                                posicoes[l, c] = " ";
                            }

                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine($"                       {posicoes[0, 0]}   {posicoes[0, 1]}   {posicoes[0, 2]}");
                    Console.WriteLine("                      ---│---│---");
                    Console.WriteLine($"                       {posicoes[1, 0]}   {posicoes[1, 1]}   {posicoes[1, 2]}");
                    Console.WriteLine("                      ---│---│---");
                    Console.WriteLine($"                       {posicoes[2, 0]}   {posicoes[2, 1]}   {posicoes[2, 2]}");

                    quantidadeJogadas++;

                    if (posicoes[0, 0] == posicoes[0, 1] && posicoes[0, 2] == posicoes[0, 0]) {
                        if (posicoes[0, 0] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na horizontal \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 0] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na horizontal \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[1, 0] == posicoes[1, 1] && posicoes[1, 2] == posicoes[1, 0]) {
                        if (posicoes[1, 0] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na horizontal \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[1, 0] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na horizontal \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[2, 0] == posicoes[2, 1] && posicoes[2, 2] == posicoes[2, 0]) {
                        if (posicoes[2, 0] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na horizontal \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[2, 0] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na horizontal \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[0, 0] == posicoes[1, 0] && posicoes[2, 0] == posicoes[0, 0]) {
                        if (posicoes[0, 0] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na vertical \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 0] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na vertical \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[0, 1] == posicoes[1, 1] && posicoes[2, 1] == posicoes[0, 1]) {
                        if (posicoes[0, 1] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na vertical \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 1] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na vertical \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[0, 2] == posicoes[1, 2] && posicoes[2, 2] == posicoes[0, 2]) {
                        if (posicoes[0, 2] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na vertical \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 2] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na vertical \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[0, 0] == posicoes[1, 1] && posicoes[2, 2] == posicoes[0, 0]) {
                        if (posicoes[0, 0] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na diagonal \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 0] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na diagonal \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (posicoes[0, 2] == posicoes[1, 1] && posicoes[2, 0] == posicoes[0, 2]) {
                        if (posicoes[0, 2] == "X") {
                            Console.WriteLine($"Jogador {jogador1} ganhou na diagonal \nFim de jogo");
                            pontuacaoJogador1++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        } else if (posicoes[0, 2] == "O") {
                            Console.WriteLine($"Jogador {jogador2} ganhou na diagonal \nFim de Jogo");
                            pontuacaoJogador2++;
                            pontuacao++;
                            posicoes = new string[3, 3];
                        }
                    }

                    if (quantidadeJogadas == 9) {
                        Console.WriteLine("Deu velha");
                        velha++;
                        pontuacao++;
                    }
                } while (pontuacao == 0);

                quantidadeJogadas = 0;
                Menu();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                if(opcao == 1) {
                    posicoes = new string[3, 3];
                    if(jogador % 2 == 1) {
                        Console.WriteLine();
                        Console.WriteLine("Vez do jogador 2");
                    } else {
                        Console.WriteLine();
                        Console.WriteLine("Vez do jogador 1");
                    }
                }

                if(opcao == 2) {
                    Console.WriteLine("PLACAR \n" +
                        $"Jogador(a) {jogador1} está com {pontuacaoJogador1} vitória(s)\n" +
                        $"Jogador(a) {jogador2} está com {pontuacaoJogador2} vitória(s)\n");
                    if(pontuacaoJogador1 > pontuacaoJogador2) {
                        Console.WriteLine($"{jogador1} está vencendo!");
                    } else if(pontuacaoJogador1 < pontuacaoJogador2){
                        Console.WriteLine($"{jogador2} está vencendo!");
                    }else if(pontuacaoJogador1 == pontuacaoJogador2){
                        Console.WriteLine("Está empatado!");
                    }
                    Menu();
                    opcao = int.Parse(Console.ReadLine());
                }else if(opcao == 0) {
                    Console.WriteLine("JOGO ENCERRADO!\n" +
                                      "OBRIGADO POR JOGAR!");
                }
 
            } while (opcao != 0);


        }

    }
}