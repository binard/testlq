using LightQueryTest.Data;
using Microsoft.AspNetCore.Mvc;
using LightQuery;
using LightQueryTest.Model;
using System.Linq;

namespace LightQueryTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly LightQueryContext _context;

        public TestController(LightQueryContext context)
        {
            _context = context;
        }

        [HttpGet]
        [LightQuery(forcePagination: true, defaultPageSize: 3, defaultSort: "date asc")]
        public IActionResult Get()
        {
            var result = _context.TableTest
                .Select(c => new MyChildrenData()
                {
                    Label = c.Label,
                    Date = c.Date

                });
            return Ok(result);
        }
    }
}
