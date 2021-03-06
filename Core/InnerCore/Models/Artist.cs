﻿using System;
using System.Collections.Generic;

namespace Arachnee.InnerCore.Models
{
    public class Artist : Entry
    {
        public string Biography { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime? Deathday { get; set; }
        
        public string ImdbId { get; set; }

        public string Name { get; set; }

        public List<string> NickNames { get; set; }
        
        public double Popularity { get; set; }
        
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }

        public Artist(Id id) : base(id)
        {
        }
    }
}
