﻿using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Services
{
    public class SeriesService : ISeriesService
    {
        public async Task<List<SeriesEntity>> GetAllSeries()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://frecar-epguides-api-v1.p.rapidapi.com/"),
                Headers =
                {
                    { "X-RapidAPI-Key", "1f1328d25dmshba3095b7bdaed3ep11f3cajsn1559259411bf" },
                    { "X-RapidAPI-Host", "frecar-epguides-api-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JArray.Parse(body);
                var series = json.ToObject<List<SeriesEntity>>();
                return series;
            }
        }

    }

    public class SeriesEntity
    {
        public string epguides_name { get; set; }
        public string episodes { get; set; }
        public string first_episode { get; set; }
        public string next_episode { get; set; }
        public string last_episode { get; set; }
        public string epguides_url { get; set; }
    }

    public interface ISeriesService
    {
        Task<List<SeriesEntity>> GetAllSeries();
    }
}