using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Project
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("url")]
        public string GithubUrl { get; set; }
        [JsonPropertyName("img")]
        public string PictureUrl { get; set; }
        public List<string[]> Tags { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Project>(this);

    }

}
