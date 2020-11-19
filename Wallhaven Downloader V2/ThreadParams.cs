using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallhaven_Downloader_V2 {
    struct ThreadParams {
        public List<Image> images;
        public int thread_id;
        public int total_to_download;

        public ThreadParams(List<Image> images, int thread_id, int total_to_download) {
            this.images = images;
            this.thread_id = thread_id;
            this.total_to_download = total_to_download;
        }
    }
}
