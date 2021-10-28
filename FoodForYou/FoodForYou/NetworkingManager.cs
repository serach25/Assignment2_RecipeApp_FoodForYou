using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace FoodForYou
{
    public class NetworkingManager
    {
        private string url = "https://api.spoonacular.com";
        private string key = "fb0a4cc420764b8abeb1a210dd69411a";
        private string restOfURL1 = "/recipes/complexSearch?diet=";
        private string restOfURL2 = "&intolerances=";
        private string restOfURL3 = "&apiKey=";
        private string restOfURL4 = "/mealplanner/generate?timeFrame=";
        private string restOfURL5 = "&targetCalories=";
        private string restOfURL6 = "&diet=";
        private string restOfURL7 = "&exclude=";

        HttpClient client = new HttpClient();
        public NetworkingManager()
        {
        }
     
        public async Task<List<MealClass>> getPlan(string query1st, string query2nd, string query3rd, string query4th)
        {
            string completeURL = url + restOfURL4 + query1st + restOfURL5 + query2nd + restOfURL6 + query3rd + restOfURL7 + query4th + restOfURL3 + key;
            var response = await client.GetAsync(completeURL); //complete json response
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<MealClass>(); //return empty list if not found
            }
            else
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var dic = JsonConvert.DeserializeObject<Dictionary<object,object>>
                    (jsonString);
                var array = dic.ElementAt(0).Value;
                var finalList = JsonConvert.DeserializeObject<List<MealClass>>
                     (array.ToString());
                return finalList;
            }
        }


        public async Task<List<RecipeClass>> getRecipes(string query, string query2)
        {
            string completeURL = url + restOfURL1 + query + restOfURL2 + query2 + restOfURL3 + key;
            var response = await client.GetAsync(completeURL); //complete json response
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<RecipeClass>(); //return empty list if not found
            }
            else
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (jsonString);
                var array = dic.ElementAt(0).Value;
                var finalList = JsonConvert.DeserializeObject<List<RecipeClass>>
                     (array.ToString());
                return finalList;
            }

        }



          
        
           
    }
}
