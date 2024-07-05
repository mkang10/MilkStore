using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.DTO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;
using Nest;

namespace MilkStoreWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        public IGuestRepository _guestRepository;

        public GuestController(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        [HttpPost]
        [Route("uploadElasticData")]
        public async Task<IActionResult> uploadDocument()
        {
            var response = await _guestRepository.CreateDocumentAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("ViewListProduct")]
        public async Task<ResponseDTO> ViewListProducts(int productID, string productName, string description, double price, int quantity, string productType, DateTime expirationDate, double weight, string brand, double fatContent, float volume, string packagingType, string storageInstructions, string ingredients, string? sortBy = "id", string? sortOrder = "desc", int pageNumber = 1, int pageSize = 5) 
        {
            return await _guestRepository.GetListProducts(productID, productName, description, price, quantity, productType, expirationDate, weight, brand, fatContent, volume, packagingType, storageInstructions, ingredients, sortBy, sortOrder, pageNumber, pageSize);
        }

        [HttpGet]
        [Route("ViewProductDetail")]
        public async Task<ResponseDTO> ViewProductDetail(int productID)
        {
            return await _guestRepository.GetProductById(productID);
        }

        [HttpGet]
        [Route("ViewListReview")]
        public async Task<ResponseDTO> ViewProductReview(int reviewID, string userID, string productID, string ReviewContent, int rating, DateTime reviewDate) 
        {
            return await _guestRepository.GetListProductReview(reviewID, userID, productID, ReviewContent, rating, reviewDate);
        }

        [HttpGet]
        [Route("ViewArticleDetail")]
        public async Task<ResponseDTO> GetArticleById(int articleId) 
        {
            return await _guestRepository.GetArticleById(articleId);
        }

        
    }
}
