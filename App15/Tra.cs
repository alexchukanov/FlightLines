using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{

    public class Rootobject
    {
        public string type { get; set; }
        public Feature[] features { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }        
        public float[][] coordinates { get; set; }
    }

    public class Properties
    {
        public string id { get; set; }
        public string nm { get; set; }
        public string mta { get; set; }
        public string lb { get; set; }
        public string wd { get; set; }
        public string ps { get; set; }
        public string pe { get; set; }
        public string agr { get; set; }
        public He[] he { get; set; }
        public string rmta { get; set; }
    }

    public class He
    {
        public string top { get; set; }
        public string format_top { get; set; }
        public string bottom { get; set; }
        public string format_bottom { get; set; }
    }

    public enum NotifyType
    {
        NoMessage,
        StatusMessage,
        InfoMessage,
        ErrorMessage
    };

}
