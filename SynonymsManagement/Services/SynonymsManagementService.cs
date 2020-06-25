using System.Collections.Generic;
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
            var word = _mapper.Map<Word>(wordDto);
            await _wordRepository.InsertWord(word);
        }

        public async Task<IEnumerable<WordDto>> GetWords()
        {
            return _mapper.Map<IEnumerable<WordDto>>(await _wordRepository.GetWords());
        }
    }
}
