using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baham.Entities;

public class Product : BaseEntity
{
    [Required]
    public string NameFa { get; set; }

    [Required]
    public string NameEn { get; set; }

    public string Code { get; set; }

    [Required]
    public int StoreId { get; set; }

    [Required]
    public int CategoryId { get; set; }
    
    [Column(TypeName = "text")]
    public string description { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public byte Status { get; set; }
    public int viewed { get; set; }

    [Timestamp]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    [Timestamp]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }


    // Relations
    public virtual ProductCategory Category { get; set; }
    public virtual Store Store { get; set; }


}
