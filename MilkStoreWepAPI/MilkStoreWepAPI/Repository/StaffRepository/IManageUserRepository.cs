using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository
{
    public interface IManageUserRepository
    {
        public Task<string> CreateDocumentAsync(User document);

        public Task<string> DeleteDocumentAsync(int id);

        public Task<User> GetDocumentAsync(int id);

        public Task<IEnumerable<User>> GetAllDocumentsAsync();

        public Task<string> UpdateDocumentAsync(User document);
    }
}
