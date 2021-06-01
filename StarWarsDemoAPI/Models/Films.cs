using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsDemoAPI.Models
{
    public class Films
    {
        public string title { get; set; }
        public string director { get; set; }
        public List<string> characters { get; set; }
    }

}
