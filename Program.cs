using System;

namespace TextMessageBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables for the text box.
            string name;
            DateTime date = DateTime.UtcNow;
            string message;
            int boxSize = 0;
            int marginSize = 8;     // 4 spaces on both sides
            string border = "";
            string stringBuffer = "";
            //int spaceBuffer = 0;
            int padding = 0;

            string header = "Text Message Box";
            string nameHead = "Name: ";
            string dateHead = "Date: ";
            string messageHead = "Message: ";

            // Get the data we want.
            Console.WriteLine("Welcome!");
            Console.WriteLine("Today's date is {0}", date.ToShortDateString());
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.Write("What is your message: ");
            message = Console.ReadLine();

            // Determine the maximum size of the box.
            if (name.Length + nameHead.Length >= message.Length + messageHead.Length)
            {
                boxSize = name.Length + nameHead.Length + marginSize;
            }
            else if (name.Length + nameHead.Length < message.Length + messageHead.Length)
            {
                boxSize = message.Length + messageHead.Length + marginSize;
            }

            // Draw the box!
            for (int i = 0; i < boxSize+4; i++)         // Add 4 for the side *'s
            {
                border += "*";
            }
            Console.WriteLine("{0}", border);

            stringBuffer = "**    " + header;
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            stringBuffer += "**";
            Console.WriteLine("{0}", stringBuffer);

            stringBuffer = "**    " + nameHead + name;
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            stringBuffer += "**";
            Console.WriteLine("{0}", stringBuffer);

            stringBuffer = "**    " + dateHead + date.ToShortDateString();
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            stringBuffer += "**";
            Console.WriteLine("{0}", stringBuffer);

            stringBuffer = "**    " + messageHead + message;
            padding = boxSize - stringBuffer.Length + 2;
            for (int i = 0; i < padding; i++)
            {
                stringBuffer += " ";
            }
            stringBuffer += "**";
            Console.WriteLine("{0}", stringBuffer);

            Console.WriteLine("{0}", border);

            /*Console.WriteLine("***************************************************");
            Console.WriteLine("**    Programming Assignment #4                  **");
            Console.WriteLine("**    Developer: Jeff Peterson                   **");
            Console.WriteLine("**    Date Submitted: 06/19/2017                 **");
            Console.WriteLine("**    Purpose: Showcase a console application    **");
            Console.WriteLine("***************************************************");*/
        }
    }
}
