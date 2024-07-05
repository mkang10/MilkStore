using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository
{
    public class ManageArticleRepository : IManageArticleRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public ManageArticleRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }
        public Task<string> CreateDocumentAsync(Article document)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Article>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateDocumentAsync(Article document)
        {
            throw new NotImplementedException();
        }
    }
}
