using System.ComponentModel.DataAnnotations;

namespace shopping_cart_.Models
{
    public class Product
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }

    [DataType(DataType.Date)]
    public DateTime Origin { get; set; }
    
    }
}