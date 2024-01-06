using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Catalog.Core.Entities;

[Table("ProductBrand")]
public class ProductBrand : BaseEntity
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
}