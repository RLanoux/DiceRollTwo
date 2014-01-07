using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRollTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables.
            String sUserName = String.Empty;
            Random rnd = new Random();
            Int32 iDieValue1 = 0;
            Int32 iDieValue2 = 0;

            // Greet the user.
            Console.Write("Hello! Welcome to Dice Roll Two! What is your name? ");
            sUserName = Console.ReadLine();
            Console.WriteLine();

            // Pause with a message to hit enter to roll the dice the first time.
            PauseCode("Ok, " + sUserName + ". Please hit enter to roll the dice.");

            // Randomly generate two integers between 1 and 6, inclusive, and store them.
            iDieValue1 = rnd.Next(1,7);
            iDieValue2 = rnd.Next(1,7);

            // Show the two dice together, using the method
            ShowDice(iDieValue1, iDieValue2);

            // Pause the program and tell 'em to hit enter for another roll.
            PauseCode("Ok, " + sUserName + ". Please hit enter to roll the dice.");

            // Randomly generate two integers between 1 and 6, inclusive, and store them.
            iDieValue1 = rnd.Next(1, 7);
            iDieValue2 = rnd.Next(1, 7);

            // Show the dice again with new values, using the method
            ShowDice(iDieValue1, iDieValue2);

            // Pause the program, with instructions.
            PauseCode("Ok, " + sUserName + ". Please hit enter to roll the dice.");

            // Randomly generate two integers between 1 and 6, inclusive, and store them.
            iDieValue1 = rnd.Next(1, 7);
            iDieValue2 = rnd.Next(1, 7);

            // Show dice again, using the new values
            ShowDice(iDieValue1, iDieValue2);

            // Pause the program, telling them to hit enter to close.
            PauseCode("Ok, " + sUserName + ". Please hit enter to close the program.");

        }

        static void PauseCode(String sMsg)
        {
            Console.WriteLine(sMsg);
            Console.ReadLine();
        }

        static void ShowDice(Int32 intValue, Int32 intOtherValue)
        {
            if ((intValue == 1) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            if ((intValue == 1) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            if ((intValue == 1) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            if ((intValue == 1) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            if ((intValue == 1) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            if ((intValue == 1) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 2) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 3) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 4) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 5) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 1))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 2))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 3))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|     o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o     |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 4))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 5))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
            else if ((intValue == 6) && (intOtherValue == 6))
            {
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("|_______|");
                Console.WriteLine();
            }
        }
    }
}
