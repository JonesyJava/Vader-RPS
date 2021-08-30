using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string answer = "";
            int PlayerCount = 0;
            int CompCount = 0;

            Console.WriteLine(@" 
                             __________
                      ______/ ________ \______
                    _/      ____________      \_
                  _/____________    ____________\_
                 /  ___________ \  / ___________  \
                /  /XXXXXXXXXXX\ \/ /XXXXXXXXXXX\  \
               /  /############/    \############\  \
              |   \XXXXXXXXXXX/ _  _ \XXXXXXXXXXX/   |
             __|\_____   ___   //  \\   ___   _____/|__
            [ _       \     \  X    X  /     /       _ ]
             __|     \ \                    / /     |__
             [____  \ \ \   ____________   / / /  ____]
                  \  \ \ \/||.||.||.||.||\/ / /  /
                   \_ \ \  ||.||.||.||.||  / / _/
                     \ \   ||.||.||.||.||   / /
                      \_   ||_||_||_||_||   _/
                        \     ........     /
                         \________________/

");
            while (answer != "NO")
            {
                Console.WriteLine("You have a choice:\n->Rock\n->Paper\n->Scissors");
                string[] choices = new string[3] { "Rock", "Paper", "Scissors" };
                Random rndm = new Random();
                int num = rndm.Next(0, 3);
                Console.WriteLine("Make a choice:");
                string user = Console.ReadLine();
                Console.WriteLine("Computer:" + choices[num]);

                if (user == "Paper" && choices[num] == "Scissors")
                {
                    Console.WriteLine("VADER WINS!! SCISSORS WERE YOUR WEAKNESS THIS TIME JEDI!!");
                    CompCount += 1;
                }
                else if (user == "Paper" && choices[num] == "Rock")
                {
                    Console.WriteLine("YOU WIN! YOURE ON VADER LIKE WHITE ON RICE!!");
                    PlayerCount += 1;
                }
                else if (user == "Rock" && choices[num] == "Paper")
                {
                    Console.WriteLine("VADER WINS! THE WAR ISNT OVER JEDI");
                    CompCount += 1;
                }
                else if (user == "Rock" && choices[num] == "Scissors")
                {
                    Console.WriteLine("YOU WIN JEDI!! YOU CRUSHED VADER'S SCISSORS!");
                    PlayerCount += 1;
                }
                else if (user == "Scissors" && choices[num] == "Rock")
                {
                    Console.WriteLine("VADER WINS!! VADER KNOWS YOUR WEAKNESS JEDI!");
                    CompCount += 1;
                }
                else if (user == "Scissors" && choices[num] == "Paper")
                {
                    Console.WriteLine("YOU WIN! YOU CUT INTO VADER'S DARK SIDE WITH EASE!!");
                    PlayerCount += 1;
                }
                else
                {
                    Console.WriteLine("TIE! THE FORCE IS STRONG WITHIN YOU BOTH JEDI");
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("JEDI: " + PlayerCount + "------");
                Console.WriteLine("VADER: " + CompCount + "------");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("Want to play again, Jedi? (Yes or No)");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("----NEXT --||-- BATTLE----");
            }
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }

    }
}