namespace Baham.Entities;

public class ProductItemValue : BaseEntity
{
    public int ProductId { get; set; }
    public int ItemCategoryId { get; set; }
    public string Value { get; set; }




    public virtual Product Product { get; set; }
    public virtual ItemCategory ItemCategory { get; set; }
}
