/*

    Tic Tac Toe game written by GingerCRO 
    as a console app in the C# language. 

    Visit my projects: https://github.com/GingerCRO

*/

using System;

namespace KrizicKruzic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrix = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int field = 0;

            for (int step=0; step<9; step++)
            {
                Console.Clear();

                Console.Write("PLAYER 1 --> X");
                Console.Write("\nPLAYER 2 --> O");

                Console.WriteLine("\n\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7], matrix[8]);

                do
                {
                    Console.Write("\nEnter the field number: ");
                    field = int.Parse(Console.ReadLine());

                }while ((field <= 0) || (field >= 10) || (matrix[field - 1] == "X") || (matrix[field - 1] == "O"));

                if ((step % 2 == 0))
                {
                    matrix[field - 1] = "X";
                }
                else if ((step % 2 != 0))
                {
                    matrix[field - 1] = "O"; 
                }
                 
                if (((matrix[0] == "X") && (matrix[1] == "X") && (matrix[2] == "X")) || ((matrix[3] == "X") && (matrix[4] == "X") && (matrix[5] == "X")) || ((matrix[6] == "X") && (matrix[7] == "X") && (matrix[8] == "X")) || ((matrix[0] == "X") && (matrix[3] == "X") && (matrix[6] == "X")) || ((matrix[1] == "X") && (matrix[4] == "X") && (matrix[7] == "X")) || ((matrix[2] == "X") && (matrix[5] == "X") && (matrix[8] == "X")) || ((matrix[0] == "X") && (matrix[4] == "X") && (matrix[8] == "X")) || ((matrix[2] == "X") && (matrix[4] == "X") && (matrix[6] == "X")))
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7], matrix[8]);
                    Console.WriteLine("\nPLAYER 1 WON!");
                    System.Environment.Exit(0);
                }
                else if (((matrix[0] == "O") && (matrix[1] == "O") && (matrix[2] == "O")) || ((matrix[3] == "O") && (matrix[4] == "O") && (matrix[5] == "O")) || ((matrix[6] == "O") && (matrix[7] == "O") && (matrix[8] == "O")) || ((matrix[0] == "O") && (matrix[3] == "O") && (matrix[6] == "O")) || ((matrix[1] == "O") && (matrix[4] == "O") && (matrix[7] == "O")) || ((matrix[2] == "O") && (matrix[5] == "O") && (matrix[8] == "O")) || ((matrix[0] == "O") && (matrix[4] == "O") && (matrix[8] == "O")) || ((matrix[2] == "O") && (matrix[4] == "O") && (matrix[6] == "O")))
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7], matrix[8]);
                    Console.WriteLine("\nPLAYER 2 WON!");
                    System.Environment.Exit(0);
                }
                else if (step == 8)
                {
                    Console.Clear();
                    Console.WriteLine("\n{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", matrix[0], matrix[1], matrix[2], matrix[3], matrix[4], matrix[5], matrix[6], matrix[7], matrix[8]);
                    Console.WriteLine("\nIT'S A DRAW!");
                    System.Environment.Exit(0);
                }

            }
        }
    }
}
