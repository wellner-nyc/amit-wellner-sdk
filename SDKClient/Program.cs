using System;
using System.Security.Permissions;
using System.Web;
using System.IO;
using TheOneSDK.Api;
using TheOneSDK.Client;
using TheOneSDK.Model;

namespace SDKClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("App started!");
            
            // init            

            // authentication setting using user name and password
            // in the default (Configuration.Default) or new Configuration()
            Configuration configuration = Configuration.Default;
            configuration.ApiKeyPrefix["Bearer"] = "Bearer";
            configuration.ApiKey["Bearer"] = "ewY4b5XY08LREjve5yON";

            try
            {
                // first arguemnt 'basePath' is optional or pass an instance of the Configuration class
                MovieApi movieApi = new MovieApi(configuration);

                Docs response = movieApi.Get();
                Console.WriteLine(response);

                string movieId = "5cd95395de30eff6ebccde57";

                Id id = movieApi.Id(movieId);
                Console.WriteLine(id);

                Quote quote = movieApi.Quote(movieId);
                Console.WriteLine(quote);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
