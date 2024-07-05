using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository.AdminRepository
{
    public interface IAdminRepository
    {
        public Task<string> ApproveAsync(int id, Voucher document);
    }
}
