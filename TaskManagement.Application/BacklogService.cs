using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain;

namespace TaskManagement.Application
{
    public class BacklogService : IBacklogService
    {
        private readonly IBacklogRepository _backlogRepository;

        public BacklogService(IBacklogRepository backlogRepository)
        {
            _backlogRepository = backlogRepository;
        }
        public List<Backlog> GetAllBacklog()
        {
            var backlog = _backlogRepository.GetAllBacklog();
            return backlog; 
        }
    }
}
