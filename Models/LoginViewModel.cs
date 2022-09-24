using System.ComponentModel.DataAnnotations;

namespace epi_site1.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
