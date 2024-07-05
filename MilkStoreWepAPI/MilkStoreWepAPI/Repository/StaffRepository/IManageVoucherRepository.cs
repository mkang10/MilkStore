using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository
{
    public interface IManageVoucherRepository
    {
        public Task<string> CreateDocumentAsync(Voucher document);

        public Task<string> DeleteDocumentAsync(int id);

        public Task<Voucher> GetDocumentAsync(int id);

        public Task<IEnumerable<Voucher>> GetAllDocumentsAsync();

        public Task<string> UpdateDocumentAsync(Voucher document);
    }
}
