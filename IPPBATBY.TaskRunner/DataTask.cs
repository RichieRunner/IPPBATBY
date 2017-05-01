using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TweetSharp;

using IPPBATBY.YahooFinance.Service;
using IPPBATBY.YahooFinance.Service.Models;
using IPPBATBY.Twitter.Service;
using System.IO;

namespace IPPBATBY.TaskRunner
{
    internal class DataTask
    {
        internal async Task Start()
        {
            YahooFinanceService yahooFinanceService = new YahooFinanceService();
            InternalTwitterService internalTwitterService = new InternalTwitterService();

            string currentPrice = await yahooFinanceService.GetCurrentPrice();
            double currentPriceDouble;
            double.TryParse(currentPrice, out currentPriceDouble);
            
            string totalAssets = await yahooFinanceService.GetTotalAssets();
            double totalAssetsDouble;
            double.TryParse(totalAssets, out totalAssetsDouble);

            string newStatus = String.Format("{0}. {1} {2:C0}. {3} {4:C}.", totalAssetsDouble > 10000000000 ? "YES" : "NO", "Total Assets: ", totalAssetsDouble, "Current Price: ", currentPriceDouble);

            //Console.WriteLine(String.Format("{0}", newStatus));

            await internalTwitterService.SendTweetWithTweetSharp(newStatus);
            await LogEventToFile(newStatus);

        }

        public async Task LogEventToFile(string statusText)
        {
            string filePath = @"F:\SSD Files\Documents\Visual Studio 2013\Projects\IPPBATBY\IPPBATBY.TaskRunner\bin\Release\EventLog.txt";
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                await file.WriteLineAsync(String.Format("{0}: {1}", DateTime.Now.ToString(), statusText));
            }
        }

    }
}
