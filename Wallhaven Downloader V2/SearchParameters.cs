using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Wallhaven_Downloader_V2 {
    public class SearchParameters {
        public string q;
        public string categories;
        public string purity;
        public string sorting;
        public string order;
        public string topRange;
        public string atleast;
        public List<string> resolutions;
        public List<string> ratios;
        public List<string> colors;
        public int page;
        public string seed;

        public SearchParameters() {
            q = "";
            categories = "111";
            purity = "100";
            sorting = "date_added";
            order = "desc";
            topRange = "1M";
            atleast = "";
            resolutions = new List<string>() { };
            colors = new List<string>() { };
            ratios = new List<String>() { };
            page = 1;
            seed = "";
        }

        public void ConvertFromJson(JObject input) {
            var new_purity = new StringBuilder("000");
            var new_categories = new StringBuilder("000");
            foreach (string purity in input.SelectToken("data.purity")) {
                switch (purity) {
                    case "sfw":
                        new_purity[0] = '1';
                        break;
                    case "sketchy":
                        new_purity[1] = '1';
                        break;
                    case "nsfw":
                        new_purity[2] = '1';
                        break;
                }
            }
            foreach (string category in input.SelectToken("data.categories")) {
                switch (category) {
                    case "general":
                        new_categories[0] = '1';
                        break;
                    case "anime":
                        new_categories[1] = '1';
                        break;
                    case "people":
                        new_categories[2] = '1';
                        break;
                }
            }
            purity = new_purity.ToString();
            categories = new_categories.ToString();
            topRange = input.SelectToken("data.toplist_range").ToString();
            if (input.SelectToken("data.resolutions").ToList().Count > 0) {
                if (input.SelectToken("data.resolutions").ToList()[0].ToString() != "") {
                    foreach (string resolution in input.SelectToken("data.resolutions")) {
                        resolutions.Add(resolution);
                    }
                }
            }
            if (input.SelectToken("data.aspect_ratios").ToList().Count > 0) {
                if (input.SelectToken("data.aspect_ratios").ToList()[0].ToString() != "") {
                    foreach (string ratio in input.SelectToken("data.aspect_ratios")) {
                        ratios.Add(ratio);
                    }
                }
            }
        }

        public override string ToString() {
            string result = $"categories={categories}&purity={purity}&sorting={sorting}&order={order}&topRange={topRange}&page={page}";
            if (q != "") {
                result += $"&q={q}";
            }
            if (sorting == "toplist") {
                result += $"&topRange={topRange}";
            }
            if (atleast != "") {
                result += $"&atleast={atleast}";
            }
            if (seed != "") {
                result += $"&seed={seed}";
            }
            if (resolutions.Count > 0) {
                result += "&resolutions=";
                result += String.Join(",", resolutions);
            }
            if (ratios.Count > 0) {
                result += "&ratios=";
                result += String.Join(",", ratios);
            }
            if (colors.Count > 0) {
                result += "&colors=";
                result += String.Join(",", colors);
            }
            return result;
        }
    }
}
