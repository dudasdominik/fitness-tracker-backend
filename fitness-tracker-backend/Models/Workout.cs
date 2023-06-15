namespace fitness_tracker_backend.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("workout")]
public class Workout
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ID { get; set; }
    public User UserId { get; set; }
    public string ExerciseType { get; set; }
    public TimeSpan Duration { get; set; }
    public string Intensity { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public double Weights { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
