using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeSynonymsManagerApi.SynonymsManagement.Dtos;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Services
{
    public interface ISynonymsManagementService
    {
        Task InsertWord(WordDto word);
        Task<IEnumerable<WordDto>> GetWords();
    }
}
