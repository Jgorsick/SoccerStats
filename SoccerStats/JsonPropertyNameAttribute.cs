using System;

namespace SoccerStats
{
    internal class JsonPropertyNameAttribute : Attribute
    {
        public string PropertyName { get; set; }
    }
}