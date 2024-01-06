using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Catalog.Core.Entities;

[Table("Product")]
public class Product : BaseEntity
{
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
    [JsonPropertyName("Summary")]
    public string? Summary { get; set; }
    [JsonPropertyName("Description")]
    public string? Description { get; set; }
    [JsonPropertyName("ImageFile")]
    public string? ImageFile { get; set; }
    [JsonPropertyName("Brands")]
    public ProductBrand? Brands { get; set; }
    [JsonPropertyName("Types")]
    public ProductType? Types { get; set; }
    [JsonPropertyName("Price")]
    public decimal Price { get; set; }
}