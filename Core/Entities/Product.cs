using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Product : BaseEntity
{
    [Required]
    [StringLength(255)] 
    public string Name { get; set; } = null!;
    [Required]
    [StringLength(1000)] 
    public string Description { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    [Required] 
    public string PictureUrl { get; set; } = null!;
    [Required]
    public ProductType ProductType { get; set; } = null!;
    [Required]
    public int ProductTypeId { get; set; }
    [Required] 
    public ProductBrand ProductBrand { get; set; } = null!;
    [Required]
    public int ProductBrandId { get; set; }
}