using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDemoAPI.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_title { get; set; }
        public string poster_path { get; set; }
    }
}
