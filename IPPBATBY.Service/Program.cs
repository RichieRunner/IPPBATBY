using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IPPBATBY.Service
{
    class Program
    {
        static void Main(string[] args)
        {

            IPPBATBYDataService dataService = new IPPBATBYDataService();
            

            /*
            long currentAssets = Convert.ToInt64(DeserializeFinancial());
            decimal currentPrice = Convert.ToDecimal(DeserializeQuoteSummary());


            string status = String.Format("{0} {1:C0}. {2} {3:C}", "Total Assets: ", currentAssets, "Current Price: ", currentPrice);

            Console.WriteLine(status);

            if (currentPrice < 10000000000)
            {
                Console.WriteLine("NO!");
            }
            */
        }


        


    }
}
