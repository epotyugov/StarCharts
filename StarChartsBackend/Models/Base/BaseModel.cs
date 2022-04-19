using System.ComponentModel.DataAnnotations.Schema;

namespace StarChartsBackend.Models.Base;

public abstract class BaseModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}