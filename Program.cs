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

            const string msg = "Merhaba ben Aytekin Erlale,\r\n" +
                "Sakarya Üniversitesi Bilgisayar Mühendisliği 4.Sınıf Öğrencisiyim." +
                "İş başvurusu için mail atıyorum kişisel cv'm ektedir.";

            brandList = await FetchData.FetchDataFromUrlAsync(Url);
            brandList.Add("aytekinerlale@gmail.com");

            foreach (var item in brandList)
            {
                Email.sendEmail(msg, "Kısmi zamanlı iş başvurusu", item);
            }



        }
    }
}
