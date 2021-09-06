using System;
using System.Collections;
namespace WordPuzzleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string word="QUIT";
            Console.WriteLine("Welcome to the game of WORD PUZZLE");
            
            Console.WriteLine("Create words of three or more letters from the word: MASTER");
            Console.WriteLine("=================================================Instructions======================================================");
            Console.WriteLine("i.	Please enter the words in uppercase");
            Console.WriteLine("ii.	Every correct word will add 1 point to your score.");
            Console.WriteLine("iii.	In order to quit from game , type ‘QUIT’.");
            Console.WriteLine("===================================================================================================================");
            ArrayList lst = new ArrayList() {"ARMETS","MATERS","MATRES","RAMETS","STREAM","TAMERS"
                ,"STRESS","ARMET","ASTER","MARES","MARSE","MARTS","MASER","MATER",
                "MATES","MEATS","RAMET","RATES","REAMS","RESAT","SATEM","SMART","SMEAR",
                "STATRE","STEAM","TAMER","TAMES","TARES","TEAMS","TEARS","TERMS","TRAMS",
                "ARES","ARMS","ARSE","ARTS","ATES","EARS","EAST","EATS","ERAS",
                "ERST","ETAS","MAES","MARE","MARS","MART","MAST","MATE","MATS",
                "MEAT","MESA","META","RAMS","RASE","RATE","RATS","REAM","REMS","REST",
                "RETS","SAME","SATE","SEAM","SEAR","SEAT","SERA","SETA","STAR","STEM",
                "TAME","TAMS","TARE","TARS","TEAM","TEAR","TEAS","TERM","TRAM","TRES",
                "TSTAR","ARE","ARM","ARS","ART","ATE","EAR","EAT","EMS","ERA","ERS","ETA","MAE",
                "MAR","MAS","MAT","MET","RAM","RAS","RAT","REM","RES","RET","SAE","SAT",
                "SEA","SER","SET","TAE","TAM","TAR","TAS","TEA","TREE","SEE"


            };
            

            Console.WriteLine("Please Enter the words:");
            int count = 0;
            int flag = 0;
            foreach (Object x in lst)
            {

                word = Console.ReadLine();

                if (lst.Contains(word))
                {

                    count++;
                    flag = 1;
                    Console.WriteLine("Correct");

                }
                if (lst.Contains(word) == false && word!="QUIT")
                {
                    Console.WriteLine("Incorrect");

                }




                if (word == "QUIT")
                {
                    Console.WriteLine();
                    break;
                }

            }   
            

            string StringEntered = word;
            if (StringEntered.Contains(word))
            {
                flag++;
                Console.WriteLine("You Entered {0} Repeated words",flag);

            }
            
            Console.WriteLine("Your Score is:" + (count-flag));
            

        }
          
        }
    }

