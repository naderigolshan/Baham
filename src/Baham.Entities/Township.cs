using System.ComponentModel.DataAnnotations.Schema;

namespace Baham.Entities;

public class Township
{
    public string TitleFa { get; set; }
    public string TitleEn { get; set; }
    public string TCode { get; set; }

    [ForeignKey("Province")]
    public int ProvinceId { get; set; }
    public Province Province { get; set; }

}
