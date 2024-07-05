using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository
{
    public class ManageVoucherRepository : IManageVoucherRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public ManageVoucherRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public Task<string> CreateDocumentAsync(Voucher document)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Voucher> GetDocumentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Voucher>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateDocumentAsync(Voucher document)
        {
            throw new NotImplementedException();
        }
    }
}
