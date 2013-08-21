using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class WebsiteSource : DatasourceBase<String>
    {
        private static readonly Random _random = new Random();

        public override string Next(IGenerationContext context)
        {
            string domain = _urls[_random.Next(0, _urls.Length)];
            return string.Format("http://www.{0}", domain);
        }

        private static readonly string[] _urls = new[]{
            "google.com",
            "facebook.com",
            "youtube.com",
            "yahoo.com",
            "live.com",
            "blogspot.com",
            "wikipedia.org",
            "twitter.com",
            "msn.com",
            "amazon.com",
            "linkedin.com.",
            "bing.com",
            "wordpress.com",
            "microsoft.com",
            "ebay.com",
            "paypal.com",
            "flickr.com",
            "craigslist.org",
            "imdb.com",
            "apple.com",
            "go.com",
            "ask.com",
            "cnn.com",
            "aol.com",
            "tumblr.com",
            "godaddy.com",
            "adobe.com",
            "about.com",
            "livejournal.com",
            "espn.go.com",
        };
    }
}