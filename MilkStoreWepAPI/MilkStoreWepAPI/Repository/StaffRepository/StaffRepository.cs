using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public StaffRepository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public Task<ResponseDTO> SendMessageAsync(string message)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> LikeArticleAsync(int likeId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> CommentArticleAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> ViewReportDetail(int reportId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> ReplyReport(int reportId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO> SendMessageAsync(string message, int messageId)
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
