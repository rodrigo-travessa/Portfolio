using Newtonsoft.Json;
using System.ComponentModel;

namespace Portfolio.Models
{
    public class DogModel
    {
        [JsonProperty("id")]
        
        public int Id { get; set; }

        [JsonProperty("name")]
       
        public string Name { get; set; }

        [JsonProperty("life_span")]
        
        public string LifeSpan { get; set; }

        [JsonProperty("origin")]
        
        public string Origin { get; set; }

        [JsonProperty("reference_image_id")]
        
        public string ImageId { get; set; }

        [JsonProperty("temperament")]
        
        public string Temperament { get; set; }

        [JsonProperty("weight")]
        
        public WeightRange Weight { get; set; }

        [JsonProperty("height")]
        
        public HeightRange Height { get; set; }

        public string ImageURL { get; set; } = "";   

        
    }

    public class WeightRange
    {
        [JsonProperty("imperial")]
        public string Imperial { get; set; }


        [JsonProperty("metric")]
        public string Metric { get; set; }
    }
    public class HeightRange
    {
        [JsonProperty("imperial")]
        public string Imperial { get; set; }


        [JsonProperty("metric")]
        public string Metric { get; set; }
    }
}
