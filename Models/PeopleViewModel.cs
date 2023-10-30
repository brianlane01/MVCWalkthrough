using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SwapiMVC.Models
{
    public class PeopleViewModel
    {
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }

        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; }

        [JsonPropertyName("films")]
        public List<string> Films { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mass")]
        public string Mass { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("edited")]
        public DateTime Edited { get; set; }

        [JsonPropertyName("url")]
        public string PeopleUrl { get; set; }

        [JsonPropertyName("homeworld")]
        public string HomeworldUrl { get; set; }

        [JsonPropertyName("species")]
        public List<string> SpeciesUrl { get; set; }

        [JsonPropertyName("starships")]
        public List<string> StarshipUrl { get; set; }

        [JsonPropertyName("vehicles")]
        public List<string> VehicleUrl { get; set; }

        public string PersonId
        {
            get
            {
                return PeopleUrl
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .LastOrDefault();
            }
        }
    }
}