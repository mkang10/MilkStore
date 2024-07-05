using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository.AdminRepository
{
    public class ManageProductRepositorycs : IManageProductRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public ManageProductRepositorycs(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public Task<string> CreateDocumentAsync(Product document)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateDocumentAsync(Product document)
        {
            throw new NotImplementedException();
        }
    }
}
