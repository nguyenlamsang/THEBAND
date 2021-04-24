using System;
using HtmlAgilityPack;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load("https://vnexpress.net/goc-nhin");
        }
    }
}
