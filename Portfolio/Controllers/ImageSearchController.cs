using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ImageSearchController : Controller
    {
        public string _apiEndpoint = "https://api.unsplash.com/search/photos";
        public string _apiKey = "knYnjK5ilCK5ZlwcEO9Y5HpFw-Deljvi3VatwKv44FY";

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> ImageSearchResults(string searchTerm)
        {

            HttpClient client = new HttpClient(); 
            var RequestTry = new HttpRequestMessage(HttpMethod.Get, _apiEndpoint);
            RequestTry.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Client-ID", _apiKey);
            RequestTry.RequestUri = new System.Uri(_apiEndpoint +"?query="+ searchTerm);

            HttpResponseMessage resp = await client.SendAsync(RequestTry);

            //resultText é uma string.
            //var resultText = await resp.Content.ReadAsStringAsync();
            var resultText = await resp.Content.ReadAsStringAsync();


            Root mappedObject = JsonConvert.DeserializeObject<Root>(resultText);
            var SearchedResult = mappedObject.results;

            return View("SearchResult", SearchedResult);
                        
        }
    }
}
