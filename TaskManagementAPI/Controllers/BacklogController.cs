using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application;
using TaskManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BacklogController : ControllerBase
    {
        private readonly IBacklogService _backlogService;

        public BacklogController(IBacklogService backlogService)
        {
            _backlogService = backlogService;
        }
        // GET: api/<BacklogController>
        [HttpGet]
        public ActionResult<List<Backlog>> Get()
        {
            var backlogList = _backlogService.GetAllBacklog();
            return Ok(backlogList);
        }
        /// <summary>
        /// create new backlog
        /// </summary>
        /// <param name="backlog"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Backlog> CreateBacklog(Backlog backlog)
        {
            var res = _backlogService.CreateBacklog(backlog);
            return Ok(res);
        }
    }
}
