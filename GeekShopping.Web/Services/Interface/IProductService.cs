using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.Interface;

public interface IProductService
{
    Task<IEnumerable<ProductModel>> GetAllAsync();
    Task<ProductModel> GetByIdAsync(long id);
    Task<ProductModel> CreateAsync(ProductModel product);
    Task<ProductModel> UpdateAsync(ProductModel product);
    Task<bool> DeleteAsync(long id);
}
