using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infrastructure
{
    public interface ITaskManagementDbContext
    {
        DbSet<Backlog> Backlogs { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Project> Projects { get; set; }
    }
}
