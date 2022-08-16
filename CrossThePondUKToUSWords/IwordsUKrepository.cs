using System;
using CrossThePondUKToUSWords.Models;
namespace CrossThePondUKToUSWords
{
    public interface IwordsUKRepository
    {
        public IEnumerable<wordsUK> GetAllWordsUK();
    }
}

