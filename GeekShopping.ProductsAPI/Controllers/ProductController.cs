using GeekShopping.ProductsAPI.Data.ValueObjects;
using GeekShopping.ProductsAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductsAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _repository.FindAllAsync();

        if (products == null)
            return NotFound();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var product = await _repository.FindByIdAsync(id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProductVO product)
    {
        if (product == null)
            return BadRequest();

        var createdProduct = await _repository.CreateAsync(product);

        if (createdProduct == null)
            return BadRequest();

        return Ok(createdProduct);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ProductVO product)
    {
        if (product == null)
            return BadRequest();

        var updatedProduct = await _repository.UpdateAsync(product);

        if (updatedProduct == null)
            return BadRequest();

        return Ok(updatedProduct);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        var deleted = await _repository.DeleteAsync(id);

        if (!deleted)
            return BadRequest();

        return Ok();
    }
}
