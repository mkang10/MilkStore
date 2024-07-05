using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;

namespace MilkStoreWepAPI.Controllers.Staff
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageArticleController : ControllerBase
    {
        public IManageArticleRepository _manageArticle;

        public ManageArticleController(IManageArticleRepository manageArticle)
        {
            _manageArticle = manageArticle;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _manageArticle.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] Article article)
        {
            var result = await _manageArticle.CreateDocumentAsync(article);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _manageArticle.GetDocumentAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] Article article)
        {
            var result = await _manageArticle.UpdateDocumentAsync(article);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDocument([FromBody] int id)
        {
            var result = await _manageArticle.DeleteDocumentAsync(id);
            return Ok(result);
        }
    }
}
