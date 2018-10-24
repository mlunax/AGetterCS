using System;
using AGetter.Okami_Subs;

namespace AScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var special = args.Length == 3 && args[2] == "true";
            var a = GettingEp.GetEpUrl(args[1], int.Parse(args[0]), special);
            foreach (var v in a)
            {
                //Console.WriteLine(v + "\n");
                Console.WriteLine(GettingEpDlUrl.GetEpDlUrl(v) + "\n");
            }
        }
    }
}