﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodyTestProject.Models
{
    public  class ApiResponseDTO
    {
        [JsonPropertyName("message")]
        public string Msg { get; set; }

        [JsonPropertyName("foodId")]
        public string foodId { get; set; }
    }
}