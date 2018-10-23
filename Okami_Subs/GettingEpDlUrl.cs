using HtmlAgilityPack;

namespace AGetter.Okami_Subs
{
    public static class GettingEpDlUrl
    {
        public static string GetEpDlUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return "GetEpDlUrl: Empty URL.";
            if (!url.StartsWith("https://okami-subs.pl/")) return "GetEpDlUrl: Only Okami-Subs.pl";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var outp = doc.DocumentNode.SelectSingleNode("//*[@id=\"app-9\"]/div[3]/div[2]/div[2]/a[1]");
            return outp.Attributes[0].Value;
        }
    }
}