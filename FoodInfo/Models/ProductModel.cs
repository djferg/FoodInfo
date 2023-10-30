using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FoodInfo.Models
{
    public class ProductModel
    {
        [JsonPropertyName("code")]
        public string Barcode { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("product_name")]
        public string Name { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

    }

    public class Ingredient
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("vegan")]
        public string Vegan { get; set; }

        [JsonPropertyName("vegetarian")]
        public string Vegetarian {  get; set; }
    }

    public class Nutriments
    {

    }
}
