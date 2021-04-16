using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAsyncAwait
{
    class Program
    {

        static void Main(string[] args)
        {
            ScaricaPaginaWebAsync("http://google.com");

            ScaricaPaginaWeb("http://google.com");

            Console.ReadLine();
        }

        static private void ScaricaPaginaWeb(string url)
        {
            Console.WriteLine("Normale avvio.");
            WebClient wc = new WebClient();
            string page = wc.DownloadString(url);
            //Console.WriteLine(page);
            Console.WriteLine("Normale fine.");
        }

        static private async void ScaricaPaginaWebAsync(string url)
        {
            Console.WriteLine("Async avvio.");
            WebClient wc = new WebClient();
            string page = await wc.DownloadStringTaskAsync(url);
            //Console.WriteLine(page);
            Console.WriteLine("Async fine.");
        }
    }
}
