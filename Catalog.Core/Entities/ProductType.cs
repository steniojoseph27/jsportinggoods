using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Catalog.Core.Entities;

[Table("ProductType")]
public class ProductType : BaseEntity
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
}