using System.ComponentModel.DataAnnotations;

namespace DB_Validate.Data.Dtos;

public class CreateUserDto
{
    [Required(ErrorMessage = "Digite seu nome")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Digite seu CPF")]
    [StringLength(14, MinimumLength = 14, ErrorMessage = "Digite um CPF válido (CPF válido = XXX.XXX.XXX-XX)")]
    public string CPF { get; set; }
    [Required(ErrorMessage = "Digite seu voto")]
    [Range(0, 1000, ErrorMessage = "Digite um voto válido")]
    public int cont { get; set; }
}
