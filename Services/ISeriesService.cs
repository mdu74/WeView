using Services.Models;

namespace Services;

public interface ISeriesService
{
    Task<List<SeriesEntity>> GetAllSeries();
}