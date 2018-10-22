using System;

namespace A_Getter
{
    class Program
    {
        static void Main(string[] args)
        {
            var special = args.Length == 3 && args[2] == "true";
            var a = Okami_Subs.GettingEp.GetEpUrl(args[1], int.Parse(args[0]), special);
            foreach (var v in a)
            {
                Console.WriteLine(v + "\n");
                Console.WriteLine(Okami_Subs.GettingEpDlUrl.GetEpDlUrl(v) + "\n");
            }
        }
    }
}