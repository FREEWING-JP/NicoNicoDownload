﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace NicoNico.Net.Entities.LiveVideo
{

    public class NicoliveVideoResponse
    {

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }

        [JsonProperty("video_info")]
        public VideoInfo[] VideoInfo { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("@status")]
        public string Status { get; set; }
    }

}
