using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Reflection;

namespace HospitalMicroservice.Doctor.Api.Repositories;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Features.Doctors.Doctor> Doctors { get; set; }
    public static AppDbContext Create(IMongoDatabase database)
    {
        var optionsBuilder =
            new DbContextOptionsBuilder<AppDbContext>().UseMongoDB(database.Client,
                database.DatabaseNamespace.DatabaseName);

        return new AppDbContext(optionsBuilder.Options);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}