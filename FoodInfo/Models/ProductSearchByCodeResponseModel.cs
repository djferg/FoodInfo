using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodInfo.Models
{
    public class ProductSearchByCodeResponseModel
    {
        [JsonPropertyName("code")]
        public string Code;

        [JsonPropertyName("product")]
        public ProductModel Product { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("status_verbose")]
        public string StatusVerbose { get; set; }
    }
}
