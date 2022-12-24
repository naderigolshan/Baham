using System.ComponentModel.DataAnnotations;

namespace Baham.Entities;

public class ProductCategory : BaseEntity
{
    [Required]
    public string NameFa { get; set; }

    [Required]
    public string NameEn { get; set; }
    public int? ParentId { get; set; }


    public virtual ProductCategory Parent { get; set; }
    public virtual ICollection<ProductCategory> Children { get; set; }
    public virtual ICollection<Product> Products { get; set; }

}
