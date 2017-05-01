using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IPPBATBY.YahooFinance.Service.Models;

using Newtonsoft.Json;

namespace IPPBATBY.YahooFinance.Service
{
    public class YahooFinanceService : BaseService
    {
        
        public async Task<string> GetCurrentPrice()
        {
            string urlEndPoint = @"https://query1.finance.yahoo.com/v10/finance/quoteSummary/PPBI?formatted=true&crumb=OBbTIit3Bcr&lang=en-US&region=US&modules=upgradeDowngradeHistory%2CrecommendationTrend%2CfinancialData%2CearningsHistory%2CearningsTrend%2CindustryTrend%2CindexTrend%2CsectorTrend&corsDomain=finance.yahoo.com";
            
            string currentPrice = null;

            var result = await this.GetJsonAsync(urlEndPoint);

            if (!result.Success)
            {
                return currentPrice;
            }

            QuoteSummaryData rootObject = JsonConvert.DeserializeObject<QuoteSummaryData>(result.Content);

            Result2[] myResult = rootObject.quoteSummary2.result2;

            currentPrice = myResult[0].financialData.currentPrice.raw.ToString();

            return currentPrice;
        }

        public async Task<string> GetTotalAssets()
        {
            string urlEndPoint = @"https://query1.finance.yahoo.com/v10/finance/quoteSummary/PPBI?formatted=true&crumb=OBbTIit3Bcr&lang=en-US&region=US&modules=incomeStatementHistory%2CcashflowStatementHistory%2CbalanceSheetHistory%2CincomeStatementHistoryQuarterly%2CcashflowStatementHistoryQuarterly%2CbalanceSheetHistoryQuarterly%2Cearnings&corsDomain=finance.yahoo.com";

            string totalAssets = null;

            var result = await this.GetJsonAsync(urlEndPoint);

            if (!result.Success)
            {
                return totalAssets;
            }

            FinancialData rootObject = JsonConvert.DeserializeObject<FinancialData>(result.Content);

            Result[] myResult = rootObject.quoteSummary1.result;

            totalAssets = myResult[0].balanceSheetHistoryQuarterly.balanceSheetStatements[0].totalAssets.raw.ToString();

            return totalAssets;
        }
        

    }
}
