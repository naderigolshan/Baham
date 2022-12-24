using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace Baham.Entities;

public class Township : BaseEntity
{
    public string TitleFa { get; set; }
    public string TitleEn { get; set; }
    public string TCode { get; set; }

    [ForeignKey("Province")]
    public int ProvinceId { get; set; }
    public Point Location { get; set; }
    public Province Province { get; set; }

}
