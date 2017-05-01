using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace IPPBATBY.Twitter.Service
{
    public class InternalTwitterService : BaseService
    {

        /// <summary>
        /// Send one tweet using TweetSharp
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task SendTweetWithTweetSharp(string status)
        {
            TweetSharp.TwitterService service = new TweetSharp.TwitterService(
                                                            ConfigurationManager.AppSettings["TwitterConsumerKey"],
                                                            ConfigurationManager.AppSettings["TwitterConsumerSecret"],
                                                            ConfigurationManager.AppSettings["TwitterAccessToken"],
                                                            ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]
                                                            );

            await this.AuthenticateAsync();

            /*
            service.SendTweet(new SendTweetOptions { Status = status }, (tweet, response) =>
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(DateTime.Now.ToString() + " Tweet Sent!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR " + response.Error.Message);
                    Console.ResetColor();
                }

            });
            */

            await Task.Run(() =>
                {
                    service.SendTweet(new SendTweetOptions { Status = status });
                });
        }


    }
}
