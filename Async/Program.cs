using System;
using System.Diagnostics;
using System.Net.Help;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
             HttpClient client = new HttpClient();
            Stopwatch stopwatch = stopwatch.StartNew();
            var a= client.GetStringAsync("www.google.com").Result; 
            var b = client.GetStringAsync("www.microsoft.com").Result; 
            var c = client.GetStringAsync("www.yahoo.com").Result; 
            var d = client.GetStringAsync("www.facebook.com").Result; 
            Console.WriteLine($"It took {"stopwatch.ElapsedMillisecond"}ms");
            


         stopwatch.Restart();
            var g= await client.GetStringAsync("www.google.com").Result; 
            var m = await client.GetStringAsync("www.microsoft.com").Result; 
            var y = await client.GetStringAsync("www.yahoo.com").Result; 
            var f = await client.GetStringAsync("www.facebook.com").Result; 
            Console.WriteLine($"It took {"stopwatch.ElapsedMillisecond"}ms");
        }
    }
}
