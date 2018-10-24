using HtmlAgilityPack;

namespace AScrapper.Okami_Subs
{
    public static class GettingEp
    {
        public static string[] GetEpUrl(string url, int number = 1, bool spec = false)
        {
            if (spec) return GetSEpUrl(url, number);
            if (string.IsNullOrEmpty(url)) return new []{"GetEpUrl: Empty URL."};
            if (!url.StartsWith("https://okami-subs.pl/")) return new[]{"GetEpUrl: Only Okami-Subs.pl"};
            if (number <= 0) return new [] {"GetEpUrl: number = 0 or < 0"};
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var outp = doc.DocumentNode.SelectSingleNode("//*[@id=\"main\"]/div[6]/div[2]/div/div[1]");
            var output = new string[number];
            var a = 3;
            for(var i = 0; i < number; i++)
            {
                var cn = i + a;
                string tmp;
                try
                {
                    tmp = outp.ChildNodes[cn].ChildNodes[1].ChildNodes[1].Attributes[0].Value;
                }
                catch
                {
                    break;
                }
                a++;
                output[i] =  "https://okami-subs.pl" + tmp;
            }

            return output;
        }

        private static string[] GetSEpUrl(string url, int number = 1)
        {
            if (string.IsNullOrEmpty(url)) return new []{"GetEpUrl: Empty URL."};
            if (!url.StartsWith("https://okami-subs.pl/")) return new[]{"GetEpUrl: Only Okami-Subs.pl"};
            if (number <= 0) return new [] {"GetEpUrl: number = 0 or < 0"};
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var outp = doc.DocumentNode.SelectSingleNode("//*[@id=\"main\"]/div[6]/div[2]/div/div[2]");
            var output = new string[number];
            var a = 3;
            for(var i = 0; i < number; i++)
            {
                var cn = i + a;
                string tmp;
                try
                {
                    tmp = outp.ChildNodes[cn].ChildNodes[1].ChildNodes[1].Attributes[0].Value;
                }
                catch
                {
                    break;
                }
                a++;
                output[i] =  "https://okami-subs.pl" + tmp;
            }

            return output;
        }
    }
    
}