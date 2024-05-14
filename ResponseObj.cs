using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("zipcode")]
    public string zipcode { get; set; }

    [JsonProperty("state_abbr")]
    public string stateabbr { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("distance")]
    public double distance { get; set; }

    [JsonProperty("latitudeClosest")]
    public string latitudeClosest { get; set; }

    [JsonProperty("longitudeClosest")]
    public string longitudeClosest { get; set; }

    [JsonProperty("countryCode")]
    public string countryCode { get; set; }

    [JsonProperty("latitudeClosestCity")]
    public object latitudeClosestCity { get; set; }

    [JsonProperty("longitudeClosestCity")]
    public object longitudeClosestCity { get; set; }

    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

    [JsonProperty("estimatedCity")]
    public bool estimatedCity { get; set; }

    [JsonProperty("nearestCities")]
    public string[] nearestCities { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
