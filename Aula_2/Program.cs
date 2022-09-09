using System;
namespace aula_02
{
    internal class Program
    {
        //Classes -------------------------------------------------------

        public class Memes_Brasil{
            public string[,] mapa = new string[10,10]; //Criando o mapa

            public Memes_Brasil(){
                for(int i = 0; i < 10; i++){
                    for(int j = 0; j < 10; j++){
                        mapa[i,j] = "--";
                    }
                }
            }
        }
    
    public static void printa_tudo(string[,] pure_de_batatas){
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < 10; j++){
                Console.WriteLine(pure_de_batatas[i,j]);
            }
        }
    }
        //Chamando tudo -------------------------------------------------------
    public static void Main()
        {
            var jogo = new Memes_Brasil();
                          
            printa_tudo(jogo.mapa); //Versao 3.1

        }  
    }      
}
// Versao 3 Main