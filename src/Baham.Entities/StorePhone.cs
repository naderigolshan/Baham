using System.ComponentModel.DataAnnotations;

namespace Baham.Entities;

public class StorePhone : BaseEntity
{
    [Required]
    public int StoreId { get; set; }

    [MaxLength(12)]
    public string Phone { get; set; } // const store PhoneNumber like 02122454221
    public virtual Store Store { get; set; }


}
