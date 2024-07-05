using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository.AdminRepository
{
    public class AdminRepository : IAdminRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public AdminRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public Task<string> ApproveAsync(int id, Voucher document)
        {
            throw new NotImplementedException();
        }
    }
}
