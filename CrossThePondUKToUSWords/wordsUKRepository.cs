using System;
using System.Data;
using CrossThePondUKToUSWords.Models;
using Dapper;

namespace CrossThePondUKToUSWords
{
    public class wordsUKRepository : IwordsUKRepository
    {
        private readonly IDbConnection _conn;

        public wordsUKRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<wordsUK> GetAllWordsUK()
        {
            return _conn.Query<wordsUK>("SELECT * FROM CrossThePond.wordsALL;");
        }



    }
}


