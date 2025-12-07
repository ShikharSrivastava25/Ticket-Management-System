using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.models;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTicket()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login Issue",
                    Description = "user unable to login with valid credentials.",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    Severity = "High",
                    TargetDate = DateTime.Now.AddDays(2),
                    Status = "Open"
                },

                new Ticket
                {
                    Id = 2,
                    ShortDescription = "Page Load Error",
                    Description = "home page fails to load.",
                    CreatedDate = DateTime.Now.AddDays(-5),
                    Severity = "Medium",
                    TargetDate = DateTime.Now.AddDays(5),
                    Status = "In Progress"
                }
            };

            return Ok(tickets);
        }
    }
}
