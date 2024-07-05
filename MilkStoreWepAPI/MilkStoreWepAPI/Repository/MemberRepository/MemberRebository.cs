using AutoMapper;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using Nest;

namespace MilkStoreWepAPI.Repository.MemberRepository
{
    public class MemberRebository : IMemberRepository
    {
        public readonly TutishopContext _dbcontext;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;
        private readonly IElasticClient _elasticClient;

        public MemberRebository(TutishopContext dbcontext, IMapper mapper, ResponseDTO responseDTO, IElasticClient elasticClient)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _responseDTO = responseDTO;
            _elasticClient = elasticClient;
        }

        public Task<Product> BuyProduct(int productId, int quantity, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Voucher> UseVoucher(int userId, int voucherId, int orderTotal)
        {
            throw new NotImplementedException();
        }

        public Task<Point> EarnPoint(int userId, string action, int amount)
        {
            throw new NotImplementedException();
        }

        public Task<Gift> redeemGift(int userId, int giftId, double pointRequired)
        {
            throw new NotImplementedException();
        }

        public Task<Review> writeReview(int userId, int productId, int rating, string reviewContent)
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
