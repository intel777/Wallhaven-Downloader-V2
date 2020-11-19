using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallhaven_Downloader_V2 {
    struct Collection {
        public string name;
        public int id;
        public string owner;

        public Collection(string name, int id, string owner) {
            this.name = name;
            this.id = id;
            this.owner = owner;
        }
    }
}
