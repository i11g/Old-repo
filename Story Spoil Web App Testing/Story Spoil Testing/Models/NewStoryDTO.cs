﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Story_Spoil_Testing.Models
{
    public class NewStoryDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
