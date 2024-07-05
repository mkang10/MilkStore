using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository
{
    public interface IManageArticleRepository
    {
        public Task<string> CreateDocumentAsync(Article document);

        public Task<string> DeleteDocumentAsync(int id);

        public Task<Article> GetDocumentAsync(int id);

        public Task<IEnumerable<Article>> GetAllDocumentsAsync();

        public Task<string> UpdateDocumentAsync(Article document);
    }
}
