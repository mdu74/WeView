using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;

namespace WeWatchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesService _seriesService;
        public SeriesController(ISeriesService seriesService)
        {
            _seriesService = seriesService ?? throw new ArgumentNullException(nameof(seriesService));
        }
        [HttpGet]
        public Task<List<ShowEntity>> GetSeries()
        {
            try
            {
                var results = _seriesService.GetAllSeries();
                return results;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
