using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeSynonymsManagerApi.SynonymsManagement.Dtos;
using AwesomeSynonymsManagerApi.SynonymsManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeSynonymsManagerApi.SynonymsManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynonymsManagementController : ControllerBase
    {
        private readonly ISynonymsManagementService _synonymsManagementService;

        public SynonymsManagementController(ISynonymsManagementService synonymsManagementService)
        {
            _synonymsManagementService = synonymsManagementService;
        }
        // GET: api/SynonymsManagement
        [HttpGet]
        public async Task<IEnumerable<WordDto>> Get()
        {
            return await _synonymsManagementService.GetWords();
        }

        // POST: api/SynonymsManagement
        [HttpPost]
        public async Task Post([FromBody] WordDto word)
        {
            await _synonymsManagementService.InsertWord(word);
        }
    }
}
