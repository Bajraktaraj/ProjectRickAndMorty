using System.Text.Json.Serialization;

namespace ProjectRickAndMorty.Models
{
    public class RickAndMortyAPIResponseModel
    {
        [JsonPropertyName("characters")]
        public Character Characters { get; set; }
    }

    public class Character
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }

    public class Origin
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("species")]
        public string Species { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("origin")]
        public Origin Origin { get; set; }
    }
}
