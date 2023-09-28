using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VismaTestDB;

namespace VismaTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DeveloperController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public DeveloperController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetDevelopers")]
        public IEnumerable<VismaTestDB.Models.Developer> Get()
        {
            return _context.Developers.ToArray();
        }

        [HttpGet(Name = "GetDevelopersWithSalaryGtManager")]
        public IEnumerable<VismaTestDB.Models.Developer> GetHighSalaries()
        {
            return _context.Developers.Where(d => d.Salary > d.Manager.Salary)
                .Include("Manager").ToArray();
        }
    }
}
