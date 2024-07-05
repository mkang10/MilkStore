using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository
{
    public class ManageUserRepository : IManageUserRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public ManageUserRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }
        public Task<string> CreateDocumentAsync(User document)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateDocumentAsync(User document)
        {
            throw new NotImplementedException();
        }
    }
}
