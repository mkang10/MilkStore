using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;
using MilkStoreWepAPI.Repository.AdminRepository;

namespace MilkStoreWepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageRevenueController : ControllerBase
    {
        public IManageRevenueRepository _manageRevenue;

        public ManageRevenueController(IManageRevenueRepository manageRevenue)
        {
            _manageRevenue = manageRevenue;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _manageRevenue.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] Revenue revenue)
        {
            var result = await _manageRevenue.CreateDocumentAsync(revenue);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _manageRevenue.GetDocumentAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] Revenue revenue)
        {
            var result = await _manageRevenue.UpdateDocumentAsync(revenue);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDocument([FromBody] int id)
        {
            var result = await _manageRevenue.DeleteDocumentAsync(id);
            return Ok(result);
        }
    }
}
