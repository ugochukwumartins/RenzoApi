using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renzorapi.Data.Model
{
    public class Poem
    {

        public int id { get; set; }
        public string Title { get; set; }
        public string Catption { get; set; }
        public string Body { get; set; }
        public DateTime Dateadded { get; set; }
    }
}
