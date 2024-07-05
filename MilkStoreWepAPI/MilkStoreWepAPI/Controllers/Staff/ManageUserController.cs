using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;
using MilkStoreWepAPI.Service;

namespace MilkStoreWepAPI.Controllers.Staff
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageUserController : ControllerBase
    {
        public IManageUserRepository _manageUserRepository;

        public ManageUserController(IManageUserRepository manageUserRepository)
        {
            _manageUserRepository = manageUserRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _manageUserRepository.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] User user)
        {
            var result = await _manageUserRepository.CreateDocumentAsync(user);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _manageUserRepository.GetDocumentAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] User user)
        {
            var result = await _manageUserRepository.UpdateDocumentAsync(user);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDocument([FromBody] int id)
        {
            var result = await _manageUserRepository.DeleteDocumentAsync(id);
            return Ok(result);
        }

    }
}
