using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Repository;

namespace MilkStoreWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        public IStaffRepository _staffRepository;

        public StaffController(IStaffRepository IStaffRepository)
        {
            _staffRepository = IStaffRepository;
        }

        [HttpPost]
        [Route("SendMessage")]
        public async Task<ResponseDTO> SendMessage(string message, int messageid)
        {
            return await _staffRepository.SendMessageAsync(message, messageid);
        }
        
        [HttpPost]
        [Route("LikeArticle")]
        public async Task<ResponseDTO> LikeArticle(int likeId)
        {
            return await _staffRepository.LikeArticleAsync(likeId);
        }

        [HttpPost]
        [Route("CommentArticle")]
        public async Task<ResponseDTO> Comment(int commentId)
        {
            return await _staffRepository.CommentArticleAsync(commentId);
        }

        [HttpGet]
        [Route("ViewReport")]
        public async Task<ResponseDTO> ViewReport(int reportId)
        {
            return await _staffRepository.ViewReportDetail(reportId);
        }
        [HttpPost]
        [Route("ReplyReport")]
        public async Task<ResponseDTO> ReplyReportDetail(int reportId)
        {
            return await _staffRepository.ReplyReport(reportId);
        }
        [HttpGet]
        [Route("GetMessage")]
        public async Task<ResponseDTO> GetMessages(int messageId)
        {
            return await _staffRepository.GetMessages(messageId);
        }

        [HttpPost]
        [Route("ReplyMessage")]

        public async Task<ResponseDTO> SendMessages(Chat message)
        {
            return await _staffRepository.ReplyMessage(message);
        }
    }
}
