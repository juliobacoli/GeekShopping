using AutoMapper;
using GeekShopping.ProductsAPI.Data.ValueObjects;
using GeekShopping.ProductsAPI.Models;
using GeekShopping.ProductsAPI.Models.Context;
using GeekShopping.ProductsAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductsAPI.Repository;

public class ProductRepository : IProductRepository
{
    private IMapper _mapper;
    private readonly MySQLContext _context;

    public ProductRepository(IMapper mapper, MySQLContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<IEnumerable<ProductVO>> FindAllAsync()
    {
        var products = await _context.Products.ToListAsync();
        return _mapper.Map<IEnumerable<ProductVO>>(products);
    }

    public async Task<ProductVO> FindByIdAsync(long id)
    {
        var product = await _context.Products.FindAsync(id);
        return _mapper.Map<ProductVO>(product);
    }

    public async Task<ProductVO> CreateAsync(ProductVO vo)
    {
        var product = _mapper.Map<Product>(vo);

        if (await _context.Products.AnyAsync(p => p.Name == product.Name))
            return null;
        
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductVO>(product);
    }
    public async Task<ProductVO> UpdateAsync(ProductVO vo)
    {
        var product = _mapper.Map<Product>(vo);
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductVO>(product);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null)
            return false;

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }
}
