using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.ProductsAPI.Models.Base;

namespace GeekShopping.ProductsAPI.Models;

[Table("product")]
public class Product : BaseEntity
{
    [Column("name")]
    [Required]
    [StringLength(150)]
    public string Name { get; set; }
    
    [Column("price")]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }
    
    [Column("description")]
    [StringLength(500)]
    public string Description { get; set; }
    
    [Column("catergory_name")]
    [StringLength(50)]
    public string CatergoryName { get; set; }
    
    [Column("image_url")]
    [StringLength(300)]
    public string ImageUrl { get; set; }
}