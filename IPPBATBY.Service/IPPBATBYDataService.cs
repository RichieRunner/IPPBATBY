using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace IPPBATBY.Service
{
    public class IPPBATBYDataService
    {
        public string DeserializeFinancial()
            {
                string urlEndPoint = @"https://query1.finance.yahoo.com/v10/finance/quoteSummary/PPBI?formatted=true&crumb=OBbTIit3Bcr&lang=en-US&region=US&modules=incomeStatementHistory%2CcashflowStatementHistory%2CbalanceSheetHistory%2CincomeStatementHistoryQuarterly%2CcashflowStatementHistoryQuarterly%2CbalanceSheetHistoryQuarterly%2Cearnings&corsDomain=finance.yahoo.com";

                // Make Web Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlEndPoint);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Read response as stream
                Stream stream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream);
                string responseBody = streamReader.ReadToEnd();

                // Deserialize JSON
                FinancialData rootObject = JsonConvert.DeserializeObject<FinancialData>(responseBody);

                Result[] myResult = rootObject.quoteSummary1.result;

                string totalAssets = myResult[0].balanceSheetHistoryQuarterly.balanceSheetStatements[0].totalAssets.raw.ToString();

                return totalAssets;

            }

            public string DeserializeQuoteSummary()
            {
                string urlEndPoint = @"https://query1.finance.yahoo.com/v10/finance/quoteSummary/PPBI?formatted=true&crumb=OBbTIit3Bcr&lang=en-US&region=US&modules=upgradeDowngradeHistory%2CrecommendationTrend%2CfinancialData%2CearningsHistory%2CearningsTrend%2CindustryTrend%2CindexTrend%2CsectorTrend&corsDomain=finance.yahoo.com";
            
                // Make Web Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlEndPoint);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Read response as stream
                Stream stream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream);
                string responseBody = streamReader.ReadToEnd();

                // Deserialize JSON
                QuoteSummaryData rootObject = JsonConvert.DeserializeObject<QuoteSummaryData>(responseBody);

                Result2[] myResult = rootObject.quoteSummary2.result2;

                string currentPrice = myResult[0].financialData.currentPrice.raw.ToString();

                return currentPrice;

        
            }

    }
}
