using TaskManagement.Application;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infrastructure
{
    public class BacklogRepository : IBacklogRepository
    {
        private readonly TaskManagementDbContext _taskManagementDbContext;

        public BacklogRepository(TaskManagementDbContext taskManagementDbContext)
        {
            _taskManagementDbContext = taskManagementDbContext;
        }
        //public static List<Backlog> backlogs = new List<Backlog>()
        //{
        //    new Backlog { BacklogId = "1", Name = "sd", Description = "asdfa", ReportedBy = new DateTime().ToString(), ReportedDate = new DateTime().ToString() },
        //    new Backlog { BacklogId = "2", Name = "gfhj", Description = "hdfgsf", ReportedBy = new DateTime().ToString(), ReportedDate = new DateTime().ToString() }
        //};

        public List<Backlog> GetAllBacklog()
        {
            return _taskManagementDbContext.Backlogs.ToList();
        }

        public Backlog CreateBacklog(Backlog backlog)
        {
            _taskManagementDbContext.Backlogs.Add(backlog);
            _taskManagementDbContext.SaveChanges();

            return backlog;
        }   
    }
}
