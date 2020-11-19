using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallhaven_Downloader_V2 {
    class Image {
        public string id;
        public string url;
        public string filename;
        
        public Image(string id, string url) {
            this.id = id;
            this.url = url;
            this.filename = this.url.Split('/').Last();
        }
    }
}
