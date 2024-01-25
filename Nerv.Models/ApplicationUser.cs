using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Nerv.Models;

public class ApplicationUser:IdentityUser {
    [Required]
    public int Name { get; set; }
    
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
}