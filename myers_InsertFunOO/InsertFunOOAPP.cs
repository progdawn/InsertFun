//Dawn Myers
//ITDEV110
//Assignment 6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertFunOO
{
    class InsertFunOOAPP
    {
        static void Main(string[] args)
        {
            Admin setup = new Admin();
            Game work = new Game();

            setup.ConsoleSetup(); //sets up window size, color, and title
            setup.Intro(); //displays instructions
            work.GetWordPrintPoem(); //prompts users for words, and then prints poem
            setup.Goodbye(); //exit screen
        }
    }
}
