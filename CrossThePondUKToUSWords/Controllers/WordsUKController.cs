using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossThePondUKToUSWords;
using CrossThePondUKToUSWords.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossThePondUKToUSWords.Controllers
{
    public class WordsUKController : Controller
    {

        private readonly IwordsUKRepository repo;

        public WordsUKController(IwordsUKRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var words = repo.GetAllWordsUK();

            return View(words);
        }

        public IActionResult IndexA()
        {
            var words = repo.GetAllWordsUK();
            var wordsA = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'a' || word.wordUK.First() == 'A')
                {
                    wordsA.Add(word);
                }

            }

            return View(wordsA);
        }

        public IActionResult IndexB()
        {
            var words = repo.GetAllWordsUK();
            var wordsB = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'b' || word.wordUK.First() == 'B')
                {
                    wordsB.Add(word);
                }

            }

            return View(wordsB);
        }

        public IActionResult IndexC()
        {
            var words = repo.GetAllWordsUK();
            var wordsC = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'c' || word.wordUK.First() == 'C')
                {
                    wordsC.Add(word);
                }

            }

            return View(wordsC);
        }

        public IActionResult IndexD()
        {
            var words = repo.GetAllWordsUK();
            var wordsD = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'd' || word.wordUK.First() == 'D')
                {
                    wordsD.Add(word);
                }

            }

            return View(wordsD);
        }

        public IActionResult IndexE()
        {
            var words = repo.GetAllWordsUK();
            var wordsE = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'E' || word.wordUK.First() == 'E')
                {
                    wordsE.Add(word);
                }

            }

            return View(wordsE);
        }

        public IActionResult IndexF()
        {
            var words = repo.GetAllWordsUK();
            var wordsF = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'f' || word.wordUK.First() == 'F')
                {
                    wordsF.Add(word);
                }

            }

            return View(wordsF);
        }

        public IActionResult IndexG()
        {
            var words = repo.GetAllWordsUK();
            var wordsG = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'G' || word.wordUK.First() == 'G')
                {
                    wordsG.Add(word);
                }

            }

            return View(wordsG);
        }

        public IActionResult IndexH()
        {
            var words = repo.GetAllWordsUK();
            var wordsH = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'h' || word.wordUK.First() == 'H')
                {
                    wordsH.Add(word);
                }

            }

            return View(wordsH);
        }

        public IActionResult IndexI()
        {
            var words = repo.GetAllWordsUK();
            var wordsI = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'i' || word.wordUK.First() == 'I')
                {
                    wordsI.Add(word);
                }

            }

            return View(wordsI);
        }

        public IActionResult IndexJ()
        {
            var words = repo.GetAllWordsUK();
            var wordsJ = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'j' || word.wordUK.First() == 'J')
                {
                    wordsJ.Add(word);
                }

            }

            return View(wordsJ);
        }

        public IActionResult IndexK()
        {
            var words = repo.GetAllWordsUK();
            var wordsK = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'k' || word.wordUK.First() == 'K')
                {
                    wordsK.Add(word);
                }

            }

            return View(wordsK);
        }

        public IActionResult IndexL()
        {
            var words = repo.GetAllWordsUK();
            var wordsL = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'l' || word.wordUK.First() == 'L')
                {
                    wordsL.Add(word);
                }

            }

            return View(wordsL);
        }

        public IActionResult IndexM()
        {
            var words = repo.GetAllWordsUK();
            var wordsM = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'm' || word.wordUK.First() == 'M')
                {
                    wordsM.Add(word);
                }

            }

            return View(wordsM);
        }

        public IActionResult IndexN()
        {
            var words = repo.GetAllWordsUK();
            var wordsN = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'n' || word.wordUK.First() == 'N')
                {
                    wordsN.Add(word);
                }

            }

            return View(wordsN);
        }

        public IActionResult IndexO()
        {
            var words = repo.GetAllWordsUK();
            var wordsO = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'o' || word.wordUK.First() == 'O')
                {
                    wordsO.Add(word);
                }

            }

            return View(wordsO);
        }

        public IActionResult IndexP()
        {
            var words = repo.GetAllWordsUK();
            var wordsP = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'p' || word.wordUK.First() == 'P')
                {
                    wordsP.Add(word);
                }

            }

            return View(wordsP);
        }

        public IActionResult IndexQ()
        {
            var words = repo.GetAllWordsUK();
            var wordsQ = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'q' || word.wordUK.First() == 'Q')
                {
                    wordsQ.Add(word);
                }

            }

            return View(wordsQ);
        }

        public IActionResult IndexR()
        {
            var words = repo.GetAllWordsUK();
            var wordsR = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'r' || word.wordUK.First() == 'R')
                {
                    wordsR.Add(word);
                }

            }

            return View(wordsR);
        }

        public IActionResult IndexS()
        {
            var words = repo.GetAllWordsUK();
            var wordsS = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 's' || word.wordUK.First() == 'S')
                {
                    wordsS.Add(word);
                }

            }

            return View(wordsS);
        }

        public IActionResult IndexT()
        {
            var words = repo.GetAllWordsUK();
            var wordsT = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 't' || word.wordUK.First() == 'T')
                {
                    wordsT.Add(word);
                }

            }

            return View(wordsT);
        }

        public IActionResult IndexU()
        {
            var words = repo.GetAllWordsUK();
            var wordsU = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'u' || word.wordUK.First() == 'U')
                {
                    wordsU.Add(word);
                }

            }

            return View(wordsU);
        }

        public IActionResult IndexV()
        {
            var words = repo.GetAllWordsUK();
            var wordsV = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'v' || word.wordUK.First() == 'V')
                {
                    wordsV.Add(word);
                }

            }

            return View(wordsV);
        }

        public IActionResult IndexW()
        {
            var words = repo.GetAllWordsUK();
            var wordsW = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'w' || word.wordUK.First() == 'W')
                {
                    wordsW.Add(word);
                }

            }

            return View(wordsW);
        }

        public IActionResult IndexXYZ()
        {
            var words = repo.GetAllWordsUK();
            var wordsXYZ = new List<wordsUK>();
            foreach (var word in words)
            {
                if (word.wordUK.First() == 'x' || word.wordUK.First() == 'X' || word.wordUK.First() == 'y' || word.wordUK.First() == 'Y' || word.wordUK.First() == 'z' || word.wordUK.First() == 'Z')
                {
                    wordsXYZ.Add(word);
                }

            }

            return View(wordsXYZ);
        }

    }
}

