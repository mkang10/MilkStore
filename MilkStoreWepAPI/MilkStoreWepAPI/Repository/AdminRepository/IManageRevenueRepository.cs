using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository.AdminRepository
{
    public interface IManageRevenueRepository
    {
        public Task<string> CreateDocumentAsync(Revenue document);

        public Task<string> DeleteDocumentAsync(int id);

        public Task<Revenue> GetDocumentAsync(int id);

        public Task<IEnumerable<Revenue>> GetAllDocumentsAsync();

        public Task<string> UpdateDocumentAsync(Revenue document);
    }
}
