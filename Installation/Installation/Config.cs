using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installation
{
    public class Config
    {
        public string DownloadLink = "https://cdn-icons-png.flaticon.com/512/2933/2933190.png";    
        public string Extension = ".png";    
    }

    public class DownloadPaths // Do not change this...
    {
        public bool Downloads { get; set; }
        public bool Desktop { get; set; }
        public bool Documents { get; set; }
    }
}
