using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository.AdminRepository;

namespace MilkStoreWepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public IAdminRepository _adminRepository;

        public AdminController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [HttpPut]
        [Route("ApproveVouncher")]
        public async Task<IActionResult> Approve([FromBody] Voucher voucher, int id)
        {
            var result = await _adminRepository.ApproveAsync(id, voucher);
            return Ok(result);
        }
    }
}
