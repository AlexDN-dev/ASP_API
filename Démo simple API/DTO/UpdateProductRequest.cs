namespace Démo_simple_API.DTO;

public class UpdateProductRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}