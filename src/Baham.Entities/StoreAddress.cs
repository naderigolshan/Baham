using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace Baham.Entities;

public class StoreAddress : BaseEntity
{
    [Required]
    public int storeId { get; set; }
    public string Alias { get; set; }

    [Required]
    public int TownshipId { get; set; }
    public string Address { get; set; }
    public string Plate { get; set; }
    public string Unit { get; set; }
    public string PostalCode { get; set; }
    public Point Location { get; set; }

    [Timestamp]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    [Timestamp]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }

    public virtual Store Store { get; set; }
    public virtual Township Township { get; set; }
}
