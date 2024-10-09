using System;
using System.ComponentModel.DataAnnotations;
namespace SampleSecureWeb.ViewModel;

public class RegistrationViewModel
{
    [Required]
    public string? Username { get; set; }

    [Required]
    [DataType(DataType.Password)]

    public string? Password { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Konfirm Password")]
    [Compare("Password", ErrorMessage = "The Password and Confirmation Password Do Not Match")]

    public string? ConfirmPassword { get; set;}
}
