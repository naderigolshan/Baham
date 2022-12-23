using System.ComponentModel.DataAnnotations;

namespace Baham.Entities;

public class ItemCategory : BaseEntity
{
    public int ProductCategoryId { get; set; }
    public int ItemId { get; set; }

    public virtual ProductCategory ProductCategory { get; set; }
    public virtual Item Item { get; set; }
}
