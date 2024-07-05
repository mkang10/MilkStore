using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;

namespace MilkStoreWepAPI.Repository
{
    public interface IStaffRepository
    {

        public Task<ResponseDTO> SendMessageAsync(string message, int messageId);

        public Task<ResponseDTO> LikeArticleAsync(int likeId);

        public Task<ResponseDTO> CommentArticleAsync(int commentId);

        public Task<ResponseDTO> ViewReportDetail(int reportId);

        public Task<ResponseDTO> ReplyReport(int reportId);

        public Task<ResponseDTO> GetMessages(int messageId);

        public Task<ResponseDTO> ReplyMessage(Chat message);


    }
}
