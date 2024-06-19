using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain;

namespace TaskManagement.Infrastructure
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            //one company has many projects
            modelBuilder.Entity<Project>()
                .HasOne<Company>(s => s.Company)
                .WithMany(r => r.Projects)
                .HasForeignKey(p => p.CompanyId);

            //many to many
            //multiple members can be in multiple projects
            //modelBuilder.Entity<MembersProject>()
            //    .HasKey(p => new {p.ProjectId,g.MemberId});

            
        }

        public DbSet<Backlog> Backlogs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }

        
    }
}
