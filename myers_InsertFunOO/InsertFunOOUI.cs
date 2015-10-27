using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InsertFunOO
{
    class InsertFunOOUI
    {
        string word = "asdf";

        public InsertFunOOUI()
        {

        }

        public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
            }
        }

        //prompts user to enter a verb. Used in the Game class to store a verb into a variable
        public string RequestVerb()
        {
            Console.Write("Plese enter a verb >> ");
            word = Console.ReadLine();
            return word;
        }

        //prompts user to enter a nouin. Used in the Game class to store a noun into multiple variables
        public string RequestNoun()
        {

            Console.Write("Please enter a noun >> ");
            word = Console.ReadLine();
            return word;
        }

        //just like before, but with an adjective
        public string RequestAdjective()
        {
            Console.Write("Please enter an adjective >> ");
            word = Console.ReadLine();
            return word;
        }

        //prints the poem, using parameters passed in. These parameters are located in the Game class
        public string Poem(string verbOneP, string nounOneP, string nounTwoP, string adjectiveOneP, string nounThreeP)
        {
            string exitStringP; //exit string, used in a loop in Game class
            string musicNote = "\u266B"; //music note unicode character

            Console.Clear();

            Console.WriteLine("\t\t\t {0} \t\t {0}", musicNote);
            Console.WriteLine("{0} \t\t {0} \t\t {0}", musicNote);

            Console.WriteLine("\t{0} \t{1}, {1}, {1} your {2},\t\t{0}", musicNote, verbOneP, nounOneP);
            Thread.Sleep(1000);
            Console.WriteLine("\t  {0}\tGently down the {1}.\t\t{0}", musicNote, nounTwoP);
            Thread.Sleep(1000);
            Console.WriteLine(" {0}\t{1}, {1}, {1}, {1},\t{0}", musicNote, adjectiveOneP);
            Thread.Sleep(1000);
            Console.WriteLine("\t{0}\tLife is but a {1}.\t\t\t{0}", musicNote, nounThreeP);
            Thread.Sleep(1000);

            Console.WriteLine("{0} \t\t  {0}\t\t\t{0}", musicNote);
            Thread.Sleep(1000);
            Console.WriteLine("\t\t\t {0}\t\t  {0}",musicNote);
            Thread.Sleep(1000);

            //prompts user to exit or play again. Stores their selection in exitStringP
            Console.Write("\nIf you'd like to play again, press \"Y\". Otherwise, press \"N\" to exit >> ");
            exitStringP = Console.ReadLine();
            Console.Clear();
            return exitStringP;
        }
    }
}
