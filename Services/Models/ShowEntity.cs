using System.ComponentModel.DataAnnotations;

namespace Services.Models;

public class ShowEntity
{
    public string epguides_name { get; set; }
    public string episodes { get; set; }
    public string first_episode { get; set; }
    public string next_episode { get; set; }
    public string last_episode { get; set; }
    public string epguides_url { get; set; }
}