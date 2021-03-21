using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD___Bowling_Game_Demo;

/**
 * @author ${Anas Al Kala}
 *
 * 
 */
namespace TDD___Bowling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlingGameLogic game = new BowlingGameLogic();
            for (int i = 1;i< 11; i++)
            {
                Console.WriteLine("Enter the score of the first roll of the Frame " + i);
                int numberOfPinsThatWereHitFirst;
                int.TryParse(Console.ReadLine(),out numberOfPinsThatWereHitFirst);
                game.Roll(numberOfPinsThatWereHitFirst);
                if (numberOfPinsThatWereHitFirst != 10)
                {
                    Console.WriteLine("Enter the score of the second roll of the Frame " + i);
                    int numberOfPinsThatWereHitSecond;
                    int.TryParse(Console.ReadLine(), out numberOfPinsThatWereHitSecond);
                    game.Roll(numberOfPinsThatWereHitSecond);
                    if(numberOfPinsThatWereHitFirst+numberOfPinsThatWereHitSecond==10)
                        Console.WriteLine("SPARE!\n");
                }
                else
                {
                    Console.WriteLine("STRIKE!!!\n");
                }
            }

            Console.WriteLine("\nYour final score is: "+game.GetFinalScore());
            Console.WriteLine(Console.ReadLine());
        }
    }
}
