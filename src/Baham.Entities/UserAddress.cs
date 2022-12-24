using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace Baham.Entities;

public class UserAddress : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey("Township")]
    public int TownshipId { get; set; }
    public Township Township { get; set; }

    public string address { get; set; }

    public string Plate { get; set; }
    public string Unit { get; set; }
    public string PostalCode { get; set; }
    public Point Location { get; set; }
}
