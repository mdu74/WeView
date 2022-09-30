using Microsoft.AspNetCore.Mvc;
using Services;

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
        public Task<List<SeriesEntity>> GetSeries()
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
