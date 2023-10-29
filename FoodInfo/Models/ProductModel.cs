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

    }
}
