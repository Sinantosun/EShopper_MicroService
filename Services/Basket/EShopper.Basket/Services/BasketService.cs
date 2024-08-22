using EShopper.Basket.Dtos;
using EShopper.Basket.Settings;
using System.Text.Json;


namespace EShopper.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasketAsync(string userId)
        {
            await _redisService.GetDb().KeyDeleteAsync(userId);
        }

        public async Task<TotalBasketDto> GetBasketAsync(string userId)
        {
            var value = await _redisService.GetDb().StringGetAsync(userId);
            return JsonSerializer.Deserialize<TotalBasketDto>(value);
        }

        public async Task SaveBasketAsync(TotalBasketDto basket)
        {
            await _redisService.GetDb().StringSetAsync(basket.UserId,JsonSerializer.Serialize(basket));
        }
    }
}
