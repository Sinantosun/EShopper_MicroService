using EShopper.Basket.Dtos;

namespace EShopper.Basket.Services
{
    public interface IBasketService
    {
        Task<TotalBasketDto> GetBasketAsync(string userId);
        Task SaveBasketAsync(TotalBasketDto basket);
        Task DeleteBasketAsync(string userId);
    }
}
