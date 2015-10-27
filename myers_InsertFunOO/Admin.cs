using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InsertFunOO
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Insert Fun!"; //window title
            Console.SetWindowSize(105, 25); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.Black; //background color of console
            Console.ForegroundColor = ConsoleColor.White; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("Welcome to Insert Fun!");
            Thread.Sleep(500);
            Console.WriteLine("In this application, you'll be prompted to enter some words.");
            Thread.Sleep(500);
            Console.WriteLine("Those words will then be insterted into a popular nursery rhyme.");
            Thread.Sleep(500);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(500);
            Console.Write("Shutting down");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
        }
    }
}
