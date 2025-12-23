
using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingSystem.Models;

public class Appointment
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string CustomerName { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Appointment Date & Time")]
    public DateTime AppointmentDate { get; set; }

    [Required, StringLength(100)]
    public string Service { get; set; } = "Consultation";

    [StringLength(500)]
    public string? Notes { get; set; }
}
