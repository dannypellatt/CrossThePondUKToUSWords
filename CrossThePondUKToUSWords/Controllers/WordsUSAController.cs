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
    public class WordsUSAController : Controller
    {

        private readonly IwordsUKRepository repo;

        public WordsUSAController(IwordsUKRepository repo)
        {
            this.repo = repo;
        }

        #region USA to UK words

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
                if (word.wordUSA.First() == 'a' || word.wordUSA.First() == 'A')
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
                if (word.wordUSA.First() == 'b' || word.wordUSA.First() == 'B')
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
                if (word.wordUSA.First() == 'c' || word.wordUSA.First() == 'C')
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
                if (word.wordUSA.First() == 'd' || word.wordUSA.First() == 'D')
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
                if (word.wordUSA.First() == 'E' || word.wordUSA.First() == 'E')
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
                if (word.wordUSA.First() == 'f' || word.wordUSA.First() == 'F')
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
                if (word.wordUSA.First() == 'G' || word.wordUSA.First() == 'G')
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
                if (word.wordUSA.First() == 'h' || word.wordUSA.First() == 'H')
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
                if (word.wordUSA.First() == 'i' || word.wordUSA.First() == 'I')
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
                if (word.wordUSA.First() == 'j' || word.wordUSA.First() == 'J')
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
                if (word.wordUSA.First() == 'k' || word.wordUSA.First() == 'K')
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
                if (word.wordUSA.First() == 'l' || word.wordUSA.First() == 'L')
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
                if (word.wordUSA.First() == 'm' || word.wordUSA.First() == 'M')
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
                if (word.wordUSA.First() == 'n' || word.wordUSA.First() == 'N')
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
                if (word.wordUSA.First() == 'o' || word.wordUSA.First() == 'O')
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
                if (word.wordUSA.First() == 'p' || word.wordUSA.First() == 'P')
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
                if (word.wordUSA.First() == 'q' || word.wordUSA.First() == 'Q')
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
                if (word.wordUSA.First() == 'r' || word.wordUSA.First() == 'R')
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
                if (word.wordUSA.First() == 's' || word.wordUSA.First() == 'S')
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
                if (word.wordUSA.First() == 't' || word.wordUSA.First() == 'T')
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
                if (word.wordUSA.First() == 'u' || word.wordUSA.First() == 'U')
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
                if (word.wordUSA.First() == 'v' || word.wordUSA.First() == 'V')
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
                if (word.wordUSA.First() == 'w' || word.wordUSA.First() == 'W')
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
                if (word.wordUSA.First() == 'x' || word.wordUSA.First() == 'X' || word.wordUSA.First() == 'y' || word.wordUSA.First() == 'Y' || word.wordUSA.First() == 'z' || word.wordUSA.First() == 'Z')
                {
                    wordsXYZ.Add(word);
                }

            }

            return View(wordsXYZ);
        }

        #endregion

    }


}