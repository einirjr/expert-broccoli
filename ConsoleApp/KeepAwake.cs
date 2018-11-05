using System;
using System.Net;
using System.Net.Http;
using Timer = System.Timers.Timer;

namespace dinwin.Pages
{
    /// <summary>
    /// Simple class that sole purpose is to keep the heroku dynos sleep deprived!
    /// With courtesy to https://stackoverflow.com/questions/27108264/c-sharp-how-to-properly-make-a-http-web-get-request
    /// </summary>
    public static class KeepAwake
    {
        public static void Start()
        {
            Timer t = new Timer(1200000) {AutoReset = true};
            t.Elapsed += t_Elapsed;
            t.Start();
        }

        private static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://expert-broccoli.herokuapp.com/");

            var client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            }) {BaseAddress = new Uri("https://expert-broccoli.herokuapp.com/")};

            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            response.EnsureSuccessStatusCode();
        }
    }
}
