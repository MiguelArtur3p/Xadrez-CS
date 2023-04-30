
using tabuleiro;
using Xadrez_console;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino= Tela.lerPosicaoXadrez().toPosicao();
                    partida.executaMovimento(origem, destino);
                }






            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            /* try { 
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}