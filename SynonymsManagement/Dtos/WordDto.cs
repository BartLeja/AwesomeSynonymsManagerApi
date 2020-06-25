using System.Collections.Generic;

namespace AwesomeSynonymsManagerApi.SynonymsManagement.Dtos
{
    public class WordDto
    {
        public string Term { get; set; }
        public IEnumerable<string> Synonyms { get; set; }
    }
}
