using System.ComponentModel.DataAnnotations.Schema;

namespace Baham.Entities;

public class Store : BaseEntity
{
    public string NameFa { get; set; }
    public string NameEn { get; set; }
    public string Code { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    [ForeignKey("StoreCategory")]
    public int StoreCatId { get; set; }
    public StoreCategory StoreCat { get; set; }


}
