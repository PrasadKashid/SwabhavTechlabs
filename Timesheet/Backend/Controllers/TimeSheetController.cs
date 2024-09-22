using Microsoft.AspNetCore.Mvc;
using Timesheet.Model;
using Timesheet.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Timesheet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController : ControllerBase
    {

        private readonly IDateService _dateService;

        public TimeSheetController(IDateService dateService)
        {
            _dateService = dateService;
        }


        // GET: api/<TimeSheetController>
        [HttpGet]
        public IEnumerable<DateData> Get()
        {
            return _dateService.GetDateService();
        }

        // GET api/<TimeSheetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TimeSheetController>
        [HttpPost]
        public IActionResult Post([FromBody] DateData date)
        {
            _dateService.PostDateService(date);
            return Ok(new { message = "Timesheet successfully created" });
        }


        // PUT api/<TimeSheetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TimeSheetController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _dateService.DeleteDateService(id); 
            if (!result)
            {
                return NotFound(new { message = "Entry not found" });
            }
            return Ok(new { message = "Entry deleted successfully" });
        }
    }
}
