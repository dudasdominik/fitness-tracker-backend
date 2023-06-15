using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness_tracker_backend.Models;

[Table("goals")]
public class Goal
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ID { get; set; }

    public User UserId { get; set; }
    public GoalType GoalType { get; set; }
    public double TargetValue { get; set; }
    public DateTime TargetDate { get; set; }
    public double CurrentValue { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}