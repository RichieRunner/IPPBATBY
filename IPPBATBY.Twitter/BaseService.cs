using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace IPPBATBY.Twitter.Service
{
    public abstract class BaseService
    {
        /// <summary>
        /// Gets or sets the Twitter Consumer Key.
        /// </summary>
        protected string ConsumerKey { get; set; }
        /// <summary>
        /// Gets or sets the Twitter Consumer Secret.
        /// </summary>
        protected string ConsumerSecret { get; set; }
        /// <summary>
        /// Gets or sets the Twitter Acess Token.
        /// </summary>
        protected string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the Twitter Access Token Secret.
        /// </summary>
        protected string AccessTokenSecret { get; set; }


        /// <summary>
        /// Authenticates credentials
        /// </summary>
        protected async Task AuthenticateAsync()
        {

            TweetSharp.TwitterService service = new TweetSharp.TwitterService(
                                                            ConfigurationManager.AppSettings["TwitterConsumerKey"],
                                                            ConfigurationManager.AppSettings["TwitterConsumerSecret"],
                                                            ConfigurationManager.AppSettings["TwitterAccessToken"],
                                                            ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]
                                                            );

            await Task.Run(() =>
                {
                    service.AuthenticateWith(ConfigurationManager.AppSettings["TwitterAccessToken"],
                                                ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]);
                }
                );

        }

        

    }
}
