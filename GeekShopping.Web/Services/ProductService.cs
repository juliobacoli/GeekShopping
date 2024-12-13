using GeekShopping.Web.Models;
using GeekShopping.Web.Services.Interface;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    public const string BaseUrl = "api/v1/product";

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<IEnumerable<ProductModel>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync(BaseUrl);

        return await response.ReadContentAs<IEnumerable<ProductModel>>();
    }

    public async Task<ProductModel> GetByIdAsync(long id)
    {
        var response = await _httpClient.GetAsync($"{BaseUrl}/{id}");

        return await response.ReadContentAs<ProductModel>();
    }

    public async Task<ProductModel> CreateAsync(ProductModel product)
    {
        var response = await _httpClient.PostAsJsonAsync(BaseUrl, product);
        if (!response.IsSuccessStatusCode)
            throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}.");

        return await response.ReadContentAs<ProductModel>();
        
    }

    public async Task<ProductModel> UpdateAsync(ProductModel product)
    {
        var response = await _httpClient.PutAsJsonAsync(BaseUrl, product);
        if (!response.IsSuccessStatusCode)
            throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}.");

        return await response.ReadContentAs<ProductModel>();
       
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
        if (!response.IsSuccessStatusCode)
            throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}.");

        return true;
    }
}
