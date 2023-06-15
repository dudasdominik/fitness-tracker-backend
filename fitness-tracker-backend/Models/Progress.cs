namespace fitness_tracker_backend.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("progress")]
public class Progress
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ID { get; set; }
    public User UserId { get; set; }
    public DateTime Date { get; set; }
    public double Weight { get; set; }
    public double BodyMeasurements { get; set; }
    public double PerformanceMetrics { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
