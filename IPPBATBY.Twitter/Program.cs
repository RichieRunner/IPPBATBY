using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

using System.Configuration;

namespace IPPBATBY.Twitter.Service
{
    class Program
    {
        
        //private static string myConsumerKey = "HAzL5LApwSj12OW5lcNO3TvFr";
        //private static string myConsumerSecret = "NxV1U2Q1lyu22v2J9WFVd0jsFvGc5kFnMY0DuHenpncjMk3zlc";
        //private static string myAccessToken = "856809336802340868-bTXVJAJbxCBJPygDllf9W8kmzXvKkGz";
        //private static string myAccessTokenSecret = "UBdYRjKa8c44poVNCtyQXCTEc9xp6nkZYjV9zKzM3N0Ap";

        //private static TwitterService service1 = new TwitterService(myConsumerKey, myConsumerSecret, myAccessToken, myAccessTokenSecret);
        /*
        private static TwitterService service = new TwitterService(
            ConfigurationManager.AppSettings["TwitterConsumerKey"],
            ConfigurationManager.AppSettings["TwitterConsumerSecret"],
            ConfigurationManager.AppSettings["TwitterAccessToken"],
            ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]
            );
        */
        static void Main(string[] args)
        {
            //TwitterTask twitterTask = new TwitterTask();
            //twitterTask.Start().Wait();

            //SendTweetWithTweetSharp("Hello Word [write] 2");
            //Console.Read();

            //IPPBATBYDataService dataService = new IPPBATBYDataService();
            
            //long currentAssets = Convert.ToInt64(dataService.DeserializeFinancial());
            //decimal currentPrice = Convert.ToDecimal(dataService.DeserializeQuoteSummary());


            //string currentStatus = String.Format("{0} {1:C0}. {2} {3:C}", "Total Assets: ", currentAssets, "Current Price: ", currentPrice);

            //try
            //{
            //    if (currentPrice < 10000000000)
            //    {
            //        SendTweetWithTweetSharp(String.Format("{0}. {1}.", "NO", currentStatus));
            //        dataService.LogEventToFile(String.Format("{0}. {1}.", "NO", currentStatus));
            //    }
            //    else
            //    {
            //        SendTweetWithTweetSharp(String.Format("{0}. {1}.", "YES", currentStatus));
            //        dataService.LogEventToFile(String.Format("{0}. {1}.", "YES", currentStatus));
            //    }

            //}
            //catch (Exception ex)
            //{
            //    dataService.LogEventToFile(ex.ToString());
            //}

            
            //Console.Read();
            
        }
        /*
        public static void SendTweetWithTweetSharp(string _status)
        {

            service.AuthenticateWith(   ConfigurationManager.AppSettings["TwitterAccessToken"],
                                        ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]);

            service.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
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
                    Console.WriteLine("ERROR" + response.Error.Message);
                    Console.ResetColor();
                }

            });

        }
        */
    }
}
