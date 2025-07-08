using Microsoft.AspNetCore.Mvc;
using Temperance.Fallax.Models;
using Temperance.Fallax.Services;

namespace Temperance.Fallax.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private INewsProvider _newsProvider;

        public NewsController(INewsProvider newsProvider)
        {
            _newsProvider = newsProvider;
        }

        [HttpGet("latest/{symbol}")]
        public async Task<IActionResult> Get(string symbol)
        {
            var latestNews = await _newsProvider.GetNewsAsync(symbol);

            if (latestNews == null)
                return NotFound(new { message = "No news found for the specified symbol." });
            return Ok(latestNews);
        }
    }
}
