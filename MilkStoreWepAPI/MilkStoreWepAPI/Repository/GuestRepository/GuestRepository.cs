using AutoMapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository
{
    public class GuestRepository : IGuestRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public GuestRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public async Task<string> CreateDocumentAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteData()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetArticleById(int articleId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetListProductReview(int reviewID, string userID, string productID, string ReviewContent, int rating, DateTime reviewDate)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetListProducts(int productID, string productName, string description, double price, int quantity, string productType, DateTime expirationDate, double weight, string brand, double fatContent, float volume, string packagingType, string storageInstructions, string ingredients, string sortOrder = "asc", int pageNumber = 1, int pageSize = 5)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetProductById(int productID)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> GetListProducts(int productID, string productName, string description, double price, int quantity, string productType, DateTime expirationDate, double weight, string brand, double fatContent, float volume, string packagingType, string storageInstructions, string ingredients, string sortBy = "id", string sortOrder = "asc", int pageNumber = 1, int pageSize = 5)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> GetMessages(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> ReplyMessage(Chat message)
        {
            throw new NotImplementedException();
        }
    }
}
