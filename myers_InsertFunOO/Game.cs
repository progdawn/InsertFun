using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertFunOO
{
    class Game
    {
        //holds the value of words that the user will enter in
        private string verbOne = "asdf";
        private string nounOne = "asdf";
        private string nounTwo = "asdf";
        private string adjectiveOne = "asdf";
        private string nounThree = "asdf";

        private string exitString = "asdf"; //string used to exit application

        InsertFunOOUI gameUI = new InsertFunOOUI(); //instantiates UI object

        //default contructor
        public Game()
        {

        }

        //property to set/get verbOne
        public string VerbOne
        {
            get
            {
                return verbOne;
            }
            set
            {
                verbOne = value;
            }
        }

        //property to get/set nounOne
        public string NounOne
        {
            get
            {
                return nounOne;
            }
            set
            {
                nounOne = value;
            }
        }

        public string NounTwo
        {
            get
            {
                return nounTwo;
            }
            set
            {
                nounTwo = value;
            }
        }

        //property to get/set adjectiveOne
        public string AdjectiveOne
        {
            get
            {
                return AdjectiveOne;
            }
            set
            {
                AdjectiveOne = value;
            }
        }

        //property to get/set nounThree
        public string NounThree
        {
            get
            {
                return nounThree;
            }
            set
            {
                nounThree = value;
            }
        }

        //assignes values to Game class' variables by calling on the various "Request" methods in the UI class
        //Print the poem, using the Poem method in UI class
        //"Poem" returns the exitString value
        //while the user has selected to play again, continue looping
        public void GetWordPrintPoem()
        {
            while (exitString != "N" && exitString != "n")
            {
                verbOne = gameUI.RequestVerb();
                nounOne = gameUI.RequestNoun();
                nounTwo = gameUI.RequestNoun();
                adjectiveOne = gameUI.RequestAdjective();
                nounThree = gameUI.RequestNoun();

                exitString = gameUI.Poem(verbOne, nounOne, nounTwo, adjectiveOne, nounThree);
            }
        }

    }
}
