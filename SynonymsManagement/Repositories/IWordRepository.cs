using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeSynonymsManagerApi.SynonymsManagement.Models;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Repositories
{
    public interface IWordRepository
    {
        Task<IEnumerable<Word>> GetWords();
        Task InsertWord(IEnumerable<Word> words);
    }
}
