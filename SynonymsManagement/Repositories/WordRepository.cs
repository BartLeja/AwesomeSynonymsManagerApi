using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeSynonymsManagerApi.SynonymsManagement.Dapper;
using AwesomeSynonymsManagerApi.SynonymsManagement.Models;
using Dapper;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly ISqlConnectionFactory _conn;

        public WordRepository(ISqlConnectionFactory conn)
        {
            _conn = conn;
        }

        public async Task<IEnumerable<Word>> GetWords()
        {
            using var connection = _conn.GetOpenConnection();
            return await connection.QueryAsync<Word>("SELECT * FROM [SynonymsManagerDB].[dbo].[Synonyms]");
        }

        public async Task InsertWord(Word word)
        {
            using var connection = _conn.GetOpenConnection();
            await connection.ExecuteAsync("INSERT INTO  " +
                                          "[SynonymsManagerDB].[dbo].[Synonyms] " +
                                          "(Term,Synonyms) VALUES (@Term,@Synonyms)", word);
        }
    }
}
