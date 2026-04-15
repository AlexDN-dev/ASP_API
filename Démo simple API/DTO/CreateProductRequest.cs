using System.ComponentModel.DataAnnotations;

namespace Démo_simple_API.DTO;

public class CreateProductRequest
{
    [Required(ErrorMessage = "Le nom du produit est obligatoire.")]
    [StringLength(50, ErrorMessage = "Le nom du produit doit être inférieur à 50 caractères.")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "Le prix du produit est obligatoire.")]
    [Range(0.01, 10000, ErrorMessage = "Le prix doit être compris entre 0.01 et 10000.")]
    public decimal Price { get; set; }
}