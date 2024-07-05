using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;

namespace MilkStoreWepAPI.Controllers.Staff
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageVoucherController : ControllerBase
    {
        public IManageVoucherRepository _manageVoucherRepository;

        public ManageVoucherController(IManageVoucherRepository manageVoucherRepository)
        {
            _manageVoucherRepository = manageVoucherRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments()
        {
            var response = await _manageVoucherRepository.GetAllDocumentsAsync();
            return Ok(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] Voucher voucher)
        {
            var result = await _manageVoucherRepository.CreateDocumentAsync(voucher);
            return Ok(result);

        }

        [HttpGet]
        [Route("read/{id}")]
        public async Task<IActionResult> GetDocument(int id)
        {
            var document = await _manageVoucherRepository.GetDocumentAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(document);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateDocument([FromBody] Voucher voucher)
        {
            var result = await _manageVoucherRepository.UpdateDocumentAsync(voucher);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDocument([FromBody] int id)
        {
            var result = await _manageVoucherRepository.DeleteDocumentAsync(id);
            return Ok(result);
        }
    }
}
