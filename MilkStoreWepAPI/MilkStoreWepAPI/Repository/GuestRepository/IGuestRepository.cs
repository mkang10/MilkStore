using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using System.Runtime.CompilerServices;

namespace MilkStoreWepAPI.Repository
{
    public interface IGuestRepository
    {
        public Task<ResponseDTO> GetListProducts(int productID, string productName, string description, double price, int quantity, string productType, DateTime expirationDate, double weight, string brand, double fatContent, float volume, string packagingType, string storageInstructions, string ingredients,string sortBy="id", string sortOrder = "asc", int pageNumber = 1, int pageSize = 5);

        public Task<ResponseDTO> GetProductById(int productID);

        public Task<ResponseDTO> GetListProductReview(int reviewID, string userID, string productID, string ReviewContent, int rating, DateTime reviewDate);

        Task<String> CreateDocumentAsync();

        Task<bool> DeleteData();

        public Task<ResponseDTO> GetArticleById(int articleId);

        public Task<ResponseDTO> GetMessages(int messageId);

        public Task<ResponseDTO> ReplyMessage(Chat message);
    }
}
