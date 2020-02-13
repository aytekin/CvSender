using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CVSender
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string Url = "http://www.sakaryateknokent.com/yazilim-bilisim-firmalari";

            List<string> brandList;

            //brandList = await FetchData.FetchDataFromUrlAsync(Url);

            //foreach (var item in brandList)
            //{
            //    Console.WriteLine(item);
            //}

            Email.sendEmail("Merhaba ben Aytekin Erlale,\r\nİş başvurusu için mail atıyorum kişisel cv'm ektedir.", "Kısmi zamanlı iş başvurusu");


        }
    }
}
