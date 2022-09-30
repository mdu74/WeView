using Services.Models;

namespace Services;

public interface ISeriesService
{
    Task<List<ShowEntity>> GetAllSeries();
}