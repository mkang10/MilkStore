using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Service;
using System.Linq.Expressions;

namespace MilkStoreWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ESController : ControllerBase
    {
        private readonly Service.IElasticsearchService<Article> _elasticsearchService;

        public ESController(IElasticsearchService<Article> elasticsearchService)
        {
            this._elasticsearchService = elasticsearchService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _elasticsearchService.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] Article article)
        {
            var result = await _elasticsearchService.CreateDocumentAsync(article);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _elasticsearchService.GetDocumentAsync(id);
            if(document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] Article article)
        {
            var result = await _elasticsearchService.UpdateDocumentAsync(article);
            return Ok(result);
        }
    }
}
