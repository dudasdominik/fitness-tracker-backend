namespace fitness_tracker_backend.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("nutritions")]
public class Nutrition
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ID { get; set; }
    public User UserId { get; set; }
    public DateTime Date { get; set; }
    public double Calories { get; set; }
    public double Protein { get; set; }
    public double Carbohydrates { get; set; }
    public double Fats { get; set; }
    public double Water { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
