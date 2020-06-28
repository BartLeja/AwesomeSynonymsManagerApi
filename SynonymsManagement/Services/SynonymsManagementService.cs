using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AwesomeSynonymsManagerApi.SynonymsManagement.Dtos;
using AwesomeSynonymsManagerApi.SynonymsManagement.Models;
using AwesomeSynonymsManagerApi.SynonymsManagement.Repositories;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Services
{
    public class SynonymsManagementService: ISynonymsManagementService
    {
        private readonly IWordRepository _wordRepository;
        private readonly IMapper _mapper;
        public SynonymsManagementService(IWordRepository wordRepository, IMapper mapper)
        {
            _mapper = mapper;
            _wordRepository = wordRepository;
        }

        public async Task InsertWord(WordDto wordDto)
        {
            var words = new List<Word>();
            var word = _mapper.Map<Word>(wordDto);
            words.Add(word);

            var wordsFromSynonyms =  wordDto.Synonyms.Select(s => new Word(){Term = s, Synonyms = wordDto.Term });
            words.AddRange(wordsFromSynonyms);

            await _wordRepository.InsertWord(words);
        }

        public async Task<IEnumerable<WordDto>> GetWords()
        {
            return _mapper.Map<IEnumerable<WordDto>>(await _wordRepository.GetWords());
        }
    }
}
