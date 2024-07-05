using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository.AdminRepository;

namespace MilkStoreWepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageProductController : ControllerBase
    {
        public IManageProductRepository _manageProduct;

        public ManageProductController(IManageProductRepository manageProduct)
        {
            _manageProduct = manageProduct;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _manageProduct.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] Product product)
        {
            var result = await _manageProduct.CreateDocumentAsync(product);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _manageProduct.GetDocumentAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] Product product)
        {
            var result = await _manageProduct.UpdateDocumentAsync(product);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDocument([FromBody] int id)
        {
            var result = await _manageProduct.DeleteDocumentAsync(id);
            return Ok(result);
        }
    }
}
