using System.ComponentModel.DataAnnotations.Schema;

namespace StarChartsBackend.Models.Base;

public abstract class BaseModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}