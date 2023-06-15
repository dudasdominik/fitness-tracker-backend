using Microsoft.EntityFrameworkCore;

namespace fitness_tracker_backend.Models;



public class FitnessTrackerContext : DbContext
{
    public FitnessTrackerContext(DbContextOptions<FitnessTrackerContext> context) : base(context)
    {


    }


    public DbSet<Goal> Goals { get; set; }
    public DbSet<Nutrition> Nutritions { get; set; }
    public DbSet<Progress> Progresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Workout> Workouts { get; set; }

}