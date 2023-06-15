namespace fitness_tracker_backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfileName { get; set; }
    public string ProfilePicture { get; set; }
    public string Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public double? Height { get; set; }
    public double? Weight { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
