using System;

namespace TextMessageBox
{
    class Program
    {
        /**********************************************
         * TextMessageBox
         * Developer: Jeff Peterson
         * Version & Date: 0.2, 6/26/17
         * Purpose: Display a nice text message box depending on the size of a message
         * 
         * Version update: add methods to obtain input and string, use method to draw on console
         * ********************************************/

        // Global constants
        const int ASTERISK = 0;
        const int ARROWED = 1;

        static void Main(string[] args)
        {
            // Variables
            string userName;
            string message;

            // Title and purpose
            Console.WriteLine("TextMessageBox");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nProvide your name and message and see");
            Console.WriteLine("it displayed in a nice box.\n");

            // Get the input
            Console.Write("What is your name: ");
            userName = UserInput();
            Console.Write("What is your message: ");    // TODO: Create a limit for the length
            message = UserInput();

            // TODO: Get input from the user about how the box should be displayed.
            // TODO: Create a method for numeric user input and checking.

            // Display the box for the world to see.
            DisplayBox(userName, message, ARROWED, false);         // Displays title by default.


            //Console.WriteLine("***************************************************");
            //Console.WriteLine("**    Programming Assignment #4                  **");
            //Console.WriteLine("**    Developer: Jeff Peterson                   **");
            //Console.WriteLine("**    Date Submitted: 06/19/2017                 **");
            //Console.WriteLine("**    Purpose: Showcase a console application    **");
            //Console.WriteLine("***************************************************");
        }

        public static string UserInput()
        {
            /*
             * string UserInput()
             * 
             * Pauses execution while user inputs a string.
             */
            return Console.ReadLine();
        }

        public static void DisplayBox(string name, string message, int type = ASTERISK, bool showTitle = true)
        {
            /*
             * void DisplayBox(string name, string message, int type = ASTERISK, bool showTitle = true)
             * 
             * Displays a formatted box on the console containing the user name and message.
             * Provides options to change the box style and display the title or not.
             * 
             * Types: ASTERISK -> **************
             *        ARROWED  -> <><><><><><><>
             */

            // Box variables
            int boxSize = 0;
            int marginSize = 8;     // 4 spaces on both sides
            string border = "";
            string stringBuffer = "";
            //int spaceBuffer = 0;
            int padding = 0;
            DateTime date = DateTime.UtcNow;

            string title = "Text Message Box";
            string nameHead = "Name: ";
            string dateHead = "Date: ";
            string messageHead = "Message: ";

            // Determine the maximum size of the box.
            // TODO: Account for the title as well...
            if (name.Length + nameHead.Length >= message.Length + messageHead.Length)
            {
                boxSize = name.Length + nameHead.Length + marginSize;
            }
            else if (name.Length + nameHead.Length < message.Length + messageHead.Length)
            {
                boxSize = message.Length + messageHead.Length + marginSize;
            }

            // If this is an arrowed box, ensure that the size is an even number.
            if (type == ARROWED)
            {
                if (boxSize % 2 != 0)
                {
                    // Not even? Make it so!
                    boxSize += 1;
                }
            }

            // Draw the box!
            switch (type)
            {
                // First, the top of the box
                case ASTERISK:
                    for (int i = 0; i < boxSize + 4; i++)         // Add 4 for the sides
                    {
                        border += "*";
                    }
                    break;
                case ARROWED:
                    for (int i = 0; i < boxSize + 4; i += 2)
                    {
                        border += "<>";
                    }
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("{0}", border);

            // Now the sides and content
            // TODO: Make this better! It shouldn't be this messy...
            if (showTitle == true)
            {
                // Only do this if the title is to be displayed
                switch (type)
                {
                    case ASTERISK:
                        stringBuffer = "**    " + title;
                        break;
                    case ARROWED:
                        stringBuffer = "[[    " + title;
                        break;
                    default:
                        Console.WriteLine("There is an error in the program code. Contact your administrator!");
                        Console.ReadKey();
                        return;
                }
                padding = boxSize - stringBuffer.Length + 2;
                for (int i = 0; i < padding; i++)
                {
                    stringBuffer += " ";
                }
                switch (type)
                {
                    case ASTERISK:
                        stringBuffer += "**";
                        break;
                    case ARROWED:
                        stringBuffer += "]]";
                        break;
                    default:
                        Console.WriteLine("There is an error in the program code. Contact your administrator!");
                        Console.ReadKey();
                        return;
                }
                Console.WriteLine("{0}", stringBuffer);
            }

            // Now for the name section
            switch (type)
            {
                case ASTERISK:
                    stringBuffer = "**    " + nameHead + name;
                    break;
                case ARROWED:
                    stringBuffer = "[[    " + nameHead + name;
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            switch (type)
            {
                case ASTERISK:
                    stringBuffer += "**";
                    break;
                case ARROWED:
                    stringBuffer += "]]";
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("{0}", stringBuffer);

            // Next comes the date!
            switch (type)
            {
                case ASTERISK:
                    stringBuffer = "**    " + dateHead + date.ToShortDateString();
                    break;
                case ARROWED:
                    stringBuffer = "[[    " + dateHead + date.ToShortDateString();
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            switch (type)
            {
                case ASTERISK:
                    stringBuffer += "**";
                    break;
                case ARROWED:
                    stringBuffer += "]]";
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("{0}", stringBuffer);

            // Then we draw the message section
            switch (type)
            {
                case ASTERISK:
                    stringBuffer = "**    " + messageHead + message;
                    break;
                case ARROWED:
                    stringBuffer = "[[    " + messageHead + message;
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            switch (type)
            {
                case ASTERISK:
                    stringBuffer += "**";
                    break;
                case ARROWED:
                    stringBuffer += "]]";
                    break;
                default:
                    Console.WriteLine("There is an error in the program code. Contact your administrator!");
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("{0}", stringBuffer);

            // Finally, draw the base of the box
            Console.WriteLine("{0}", border);
        }
    }
}
