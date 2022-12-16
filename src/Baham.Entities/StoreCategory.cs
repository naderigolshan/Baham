using System.ComponentModel.DataAnnotations.Schema;

namespace Baham.Entities;

public class StoreCategory : BaseEntity
{
    public string NameFa { get; set; }
    public string NameEn { get; set; }
}
