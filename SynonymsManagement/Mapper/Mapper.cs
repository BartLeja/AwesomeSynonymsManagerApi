using System;
using AwesomeSynonymsManagerApi.SynonymsManagement.Dtos;
using AwesomeSynonymsManagerApi.SynonymsManagement.Models;
using AutoMapper;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<WordDto, Word>().ForMember(w=>w.Synonyms, 
                opt=>opt.MapFrom(w=> string.Join(",", w.Synonyms)));

            CreateMap<Word, WordDto>().ForMember(w => w.Synonyms, 
                opt => opt.MapFrom(w => w.Synonyms.Split(',', StringSplitOptions.None)));
        }
    }
}
