using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Models.DTO;

public class VillaNumberCreateDTO
{
    [Required]
    public int VillaNo { get; set; }
    [Required]
    public int VillaID { get; set; }
    public string SpecialDetails { get; set; }
}

