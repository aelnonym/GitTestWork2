using System;
namespace aula_02
{
    internal class Program { //Modificação 3.2
        //Classes -------------------------------------------------------

        public class Memes_Brasil{
            public string[,] map = new string[10,10]; //Creating Map

            public Memes_Brasil(){
                for(int i = 0; i < 10; i++){
                    for(int j = 0; j < 10; j++){
                        map[i,j] = "--";
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
            var games = new Memes_Brasil();
                          
            printa_tudo(games.map);//Versao 3.1


        }  
    }      
}
// Versao 4 Main Abuble memes
// Versao 2 Main
// Versao 2.1
