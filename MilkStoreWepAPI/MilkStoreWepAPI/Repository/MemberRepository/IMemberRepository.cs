using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;

namespace MilkStoreWepAPI.Repository.MemberRepository
{
    public interface IMemberRepository
    {
        public Task<Product> BuyProduct(int productId, int quantity, int userId);

        public Task<Voucher> UseVoucher(int userId, int voucherId, int orderTotal);

        public Task<Point> EarnPoint(int userId, string action, int amount);

        public Task<Gift> redeemGift(int userId, int giftId, double pointRequired);

        public Task<Review> writeReview(int userId, int productId, int rating, string reviewContent);

        public Task<ResponseDTO> GetMessages(int messageId);

        public Task<ResponseDTO> ReplyMessage(Chat message);
    }
}
