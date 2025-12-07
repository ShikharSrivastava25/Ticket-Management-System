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
                    ShortDescription = "Invalid coupon",
                    Description = "user unable to apply coupon",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    Severity = "High",
                    TargetDate = DateTime.Now.AddDays(2),
                    Status = "Open"
                },

                new Ticket
                {
                    Id = 2,
                    ShortDescription = "Page Load Error",
                    Description = "The page buffers and doesn't load",
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
