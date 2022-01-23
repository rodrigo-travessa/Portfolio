using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Models;


namespace Portfolio.Controllers
{
    public class DogController : Controller
    {
        public string _listAllBreeds = "https://api.thedogapi.com/v1/breeds";
        public string _searchByBreed = "https://api.thedogapi.com/v1/breeds/search?q=";
        public string _apiKey = "88839931-955c-484a-92eb-f4425ba44529";

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", _apiKey);

            var conteudo = await client.GetStringAsync(_listAllBreeds);
            
            List<DogModel> DogList = JsonConvert.DeserializeObject<List<DogModel>>(conteudo);
            
            return View(DogList);
        }

        
        public async Task<IActionResult> GetByBreed(string Name)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", _apiKey);
            
            string searchLink = _searchByBreed + Name;

            var conteudo = await client.GetStringAsync(searchLink);

            List<DogModel> DogList = JsonConvert.DeserializeObject<List<DogModel>>(conteudo);
            DogList.First().ImageURL = "https://cdn2.thedogapi.com/images/" + DogList[0].ImageId +".jpg";

            return View("SpecificDog", DogList);
        }
    }
}

