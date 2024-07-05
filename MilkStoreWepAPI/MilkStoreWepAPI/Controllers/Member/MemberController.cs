using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;
using MilkStoreWepAPI.Repository.MemberRepository;

namespace MilkStoreWepAPI.Controllers.Member
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        public IMemberRepository _memberRepository;

        public MemberController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [HttpPost]
        [Route("PurchaseProduct")]
        public async Task<IActionResult> PurchaseProduct(int productId, int quantity, int userId)
        {
            var response = await _memberRepository.BuyProduct(productId, quantity, userId);
            return Ok(response);

        }

        [HttpPost]
        [Route("ApplyVouncher")]
        public async Task<IActionResult> ApplyVouncher(int userId, int voucherId, int orderTotal)
        {
            var response = await _memberRepository.UseVoucher(userId, voucherId, orderTotal);
            return Ok(response);

        }

        [HttpPost]
        [Route("EarnPoint")]
        public async Task<IActionResult> Earn(int userId, string action, int amount)
        {
            var response = await _memberRepository.EarnPoint(userId, action, amount);
            return Ok(response);

        }


        [HttpPost]
        [Route("RedeemGift")]
        public async Task<IActionResult> Gift(int userId, int giftId, double pointRequired)
        {
            var response = await _memberRepository.redeemGift(userId, giftId, pointRequired);
            return Ok(response);

        }

        [HttpPost]
        [Route("WriteReview")]
        public async Task<IActionResult> writeReview(int userId, int productId, int rating, string review)
        {
            var response = await _memberRepository.writeReview(userId, productId, rating, review);
            return Ok(response);

        }
        [HttpGet]
        [Route("GetMessage")]

        public async Task<ResponseDTO> GetMessages(int messageId)
        {
            return await _memberRepository.GetMessages(messageId);
        }

        [HttpPost]
        [Route("ReplyMessage")]

        public async Task<ResponseDTO> SendMessages(Chat message)
        {
            return await _memberRepository.ReplyMessage(message);
        }


    }
}
