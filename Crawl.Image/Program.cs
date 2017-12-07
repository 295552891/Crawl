using EasyHttp.Http;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using Fizzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crawl.Image
{
    class FetchFromCosplay8
    {
        public const string SiteUrl = "http://www.cosplay8.com/pic/chinacos/2017/0829/58693.html";

        class DataStruct
        {
            public virtual string Title { get; set; }
            public virtual string Author { get; set; }
            public virtual string PublishTime { get; set; }

            public virtual string ReadCount { get; set; }

            public virtual string CommentCount { get; set; }
        }

        class Image
        {
            public virtual string ImagePath { get; set; }

            public virtual string ImageAlt { get; set; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string siteUrl = "http://www.cosplay8.com/pic/chinacos/2017/0829/58693.html";
            string htmlStr = LoadHtmlFromUrl(siteUrl);

            var html = new HtmlDocument();
            html.LoadHtml(htmlStr);

            Console.WriteLine(htmlStr);
            Console.ReadLine();
        }



        protected static string LoadHtmlFromUrl(string url)
        {
            var http = new HttpClient();
            HttpResponse resp = http.Get(url, null);
            string html = resp.RawText;
            return html;
        }

        protected static void saveToFile(string json)
        {

        }
    }
}
