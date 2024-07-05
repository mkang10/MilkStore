using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository.AdminRepository
{
    public interface IManageProductRepository
    {
        public Task<string> CreateDocumentAsync(Product document);

        public Task<string> DeleteDocumentAsync(int id);

        public Task<Product> GetDocumentAsync(int id);

        public Task<IEnumerable<Product>> GetAllDocumentsAsync();

        public Task<string> UpdateDocumentAsync(Product document);
    }
}
