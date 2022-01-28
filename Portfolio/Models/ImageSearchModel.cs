using Newtonsoft.Json;

namespace Portfolio.Models
{
    public class ImageSearchModel
    {

    }
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Urls
        {
            public string raw { get; set; }
            public string full { get; set; }
            public string regular { get; set; }
            public string small { get; set; }
            public string thumb { get; set; }
        }

        public class Links
        {
            public string self { get; set; }
            public string html { get; set; }
            public string download { get; set; }
            public string download_location { get; set; }
            public string photos { get; set; }
            public string likes { get; set; }
            public string portfolio { get; set; }
            public string following { get; set; }
            public string followers { get; set; }
        }

        public class Interiors
        {
            public string status { get; set; }
            public DateTime approved_on { get; set; }
        }

        public class TopicSubmissions
        {
            public Interiors interiors { get; set; }

            [JsonProperty("textures-patterns")]
            public TexturesPatterns TexturesPatterns { get; set; }
        }

        public class ProfileImage
        {
            public string small { get; set; }
            public string medium { get; set; }
            public string large { get; set; }
        }

        public class Social
        {
            public string instagram_username { get; set; }
            public string portfolio_url { get; set; }
            public string twitter_username { get; set; }
            public object paypal_email { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public DateTime updated_at { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string twitter_username { get; set; }
            public string portfolio_url { get; set; }
            public string bio { get; set; }
            public string location { get; set; }
            public Links links { get; set; }
            public ProfileImage profile_image { get; set; }
            public string instagram_username { get; set; }
            public int total_collections { get; set; }
            public int total_likes { get; set; }
            public int total_photos { get; set; }
            public bool accepted_tos { get; set; }
            public bool for_hire { get; set; }
            public Social social { get; set; }
        }

        public class Type
        {
            public string slug { get; set; }
            public string pretty_slug { get; set; }
        }

        public class Category
        {
            public string slug { get; set; }
            public string pretty_slug { get; set; }
        }

        public class Subcategory
        {
            public string slug { get; set; }
            public string pretty_slug { get; set; }
        }

        public class Ancestry
        {
            public Type type { get; set; }
            public Category category { get; set; }
            public Subcategory subcategory { get; set; }
        }

        public class TexturesPatterns
        {
            public string status { get; set; }
            public DateTime approved_on { get; set; }
        }

        public class CoverPhoto
        {
            public string id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public object promoted_at { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string color { get; set; }
            public string blur_hash { get; set; }
            public object description { get; set; }
            public object alt_description { get; set; }
            public Urls urls { get; set; }
            public Links links { get; set; }
            public List<object> categories { get; set; }
            public int likes { get; set; }
            public bool liked_by_user { get; set; }
            public List<object> current_user_collections { get; set; }
            public object sponsorship { get; set; }
            public TopicSubmissions topic_submissions { get; set; }
            public User user { get; set; }
        }

        public class Source
        {
            public Ancestry ancestry { get; set; }
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
            public string meta_title { get; set; }
            public string meta_description { get; set; }
            public CoverPhoto cover_photo { get; set; }
        }

        public class Tag
        {
            public string type { get; set; }
            public string title { get; set; }
            public Source source { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime? promoted_at { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string color { get; set; }
            public string blur_hash { get; set; }
            public string description { get; set; }
            public string alt_description { get; set; }
            public Urls urls { get; set; }
            public Links links { get; set; }
            public List<object> categories { get; set; }
            public int likes { get; set; }
            public bool liked_by_user { get; set; }
            public List<object> current_user_collections { get; set; }
            public object sponsorship { get; set; }
            public TopicSubmissions topic_submissions { get; set; }
            public User user { get; set; }
            public List<Tag> tags { get; set; }
               
    }

        public class Root
        {
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<Result> results { get; set; }
        }
























       
    
    //public class Resul
    //{
    //    public IndividualResult _IndividualResult { get; set; }
    //}

    //public class IndividualResult
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("alt_description")]
    //    public string AltDescription { get; set; }

    //    [JsonProperty("urls")]
    //    public ProvidedURLs URLS { get; set; }

    //    [JsonProperty("links")]
    //    public ProvidedLinks Links { get; set; }

    //    [JsonProperty("likes")]
    //    public string Likes { get; set; }
   
    //}

    //public class ProvidedURLs
    //{
    //    [JsonProperty("raw")]
    //    public string Raw { get; set; }

    //    [JsonProperty("full")]
    //    public string Full { get; set; }

    //    [JsonProperty("regular")]
    //    public string Regular { get; set; }

    //    [JsonProperty("small")]
    //    public string Small { get; set; }

    //    [JsonProperty("thumb")]
    //    public string Thumbnail { get; set; }
    //}
    //public class ProvidedLinks
    //{
    //    [JsonProperty("self")]
    //    public string ProvSelf { get; set; }

    //    [JsonProperty("html")]
    //    public string ProvHTML { get; set; }

    //    [JsonProperty("download")]
    //    public string ProvDownload { get; set; }

    //    [JsonProperty("download_location")]
    //    public string ProvDownloadLocation { get; set; }
    //}


}
