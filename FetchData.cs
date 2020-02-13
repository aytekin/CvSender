using CVSender.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CVSender
{
    public static class FetchData
    {
        
        public static async Task<List<string>> FetchDataFromUrlAsync(string url)
        {
            List<string> res = new List<string>();

            HttpClient client = new HttpClient();

            using (var response = await client.GetAsync(url))
            {
                using (var content = response.Content)
                {
                    // read answer in non-blocking way
                    var result = await content.ReadAsStringAsync();
                    var document = new HtmlDocument();
                    document.LoadHtml(result);
                    HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//td [@width='463']");

                    foreach (var item in nodes)
                    {
                        if (item.InnerText.Contains("@"))
                        {
                            res.Add(item.InnerText);
                        }
                    }

                    //Some work with page....

                }

            }

            return res;

        }
    }
}
