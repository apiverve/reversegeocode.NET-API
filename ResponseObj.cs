using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("state_abbr")]
        public string Stateabbr { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("latitudeClosest")]
        public string LatitudeClosest { get; set; }

        [JsonProperty("longitudeClosest")]
        public string LongitudeClosest { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("latitudeClosestCity")]
        public object LatitudeClosestCity { get; set; }

        [JsonProperty("longitudeClosestCity")]
        public object LongitudeClosestCity { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("estimatedCity")]
        public bool EstimatedCity { get; set; }

        [JsonProperty("nearestCities")]
        public string[] NearestCities { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
