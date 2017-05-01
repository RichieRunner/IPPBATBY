using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IPPBATBY.YahooFinance.Service.Models
{
    public class QuoteSummaryData
    {
        [JsonProperty("quoteSummary")]
        public Quotesummary2 quoteSummary2 { get; set; }
    }

    public class Quotesummary2
    {
        [JsonProperty("result")]
        public Result2[] result2 { get; set; }
        public object error { get; set; }
    }

    public class Result2
    {
        public Recommendationtrend recommendationTrend { get; set; }
        public Sectortrend sectorTrend { get; set; }
        public Upgradedowngradehistory upgradeDowngradeHistory { get; set; }
        public Indextrend indexTrend { get; set; }
        public Earningshistory earningsHistory { get; set; }
        public Industrytrend industryTrend { get; set; }
        public Earningstrend earningsTrend { get; set; }
        public Financialdata financialData { get; set; }
    }

    public class Recommendationtrend
    {
        public Trend[] trend { get; set; }
        public int maxAge { get; set; }
    }

    public class Trend
    {
        public string period { get; set; }
        public int strongBuy { get; set; }
        public int buy { get; set; }
        public int hold { get; set; }
        public int sell { get; set; }
        public int strongSell { get; set; }
    }

    public class Sectortrend
    {
        public int maxAge { get; set; }
        public object symbol { get; set; }
        public Peratio peRatio { get; set; }
        public Pegratio pegRatio { get; set; }
        public object[] estimates { get; set; }
    }

    public class Peratio
    {
    }

    public class Pegratio
    {
    }

    public class Upgradedowngradehistory
    {
        public History[] history { get; set; }
        public int maxAge { get; set; }
    }

    public class History
    {
        public int epochGradeDate { get; set; }
        public string firm { get; set; }
        public string toGrade { get; set; }
        public string fromGrade { get; set; }
        public string action { get; set; }
    }

    public class Indextrend
    {
        public int maxAge { get; set; }
        public string symbol { get; set; }
        public Peratio1 peRatio { get; set; }
        public Pegratio1 pegRatio { get; set; }
        public Estimate[] estimates { get; set; }
    }

    public class Peratio1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Pegratio1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Estimate2
    {
        public string period { get; set; }
        public Growth growth { get; set; }
    }

    public class Growth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningshistory
    {
        public History1[] history { get; set; }
        public int maxAge { get; set; }
    }

    public class History1
    {
        public int maxAge { get; set; }
        public Epsactual epsActual { get; set; }
        public Epsestimate epsEstimate { get; set; }
        public Epsdifference epsDifference { get; set; }
        public Surprisepercent surprisePercent { get; set; }
        public Quarter quarter { get; set; }
        public string period { get; set; }
    }

    public class Epsactual
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Epsestimate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Epsdifference
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Surprisepercent
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Quarter
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Industrytrend
    {
        public int maxAge { get; set; }
        public object symbol { get; set; }
        public Peratio2 peRatio { get; set; }
        public Pegratio2 pegRatio { get; set; }
        public object[] estimates { get; set; }
    }

    public class Peratio2
    {
    }

    public class Pegratio2
    {
    }

    public class Earningstrend
    {
        public Trend1[] trend { get; set; }
        public int maxAge { get; set; }
    }

    public class Trend1
    {
        public int maxAge { get; set; }
        public string period { get; set; }
        public string endDate { get; set; }
        public Growth1 growth { get; set; }
        public Earningsestimate earningsEstimate { get; set; }
        public Revenueestimate revenueEstimate { get; set; }
        public Epstrend epsTrend { get; set; }
        public Epsrevisions epsRevisions { get; set; }
    }

    public class Growth1
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Earningsestimate
    {
        public Avg avg { get; set; }
        public Low low { get; set; }
        public High high { get; set; }
        public Yearagoeps yearAgoEps { get; set; }
        public Numberofanalysts numberOfAnalysts { get; set; }
        public Growth2 growth { get; set; }
    }

    public class Avg
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Low
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class High
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Yearagoeps
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Numberofanalysts
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Growth2
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Revenueestimate
    {
        public Avg1 avg { get; set; }
        public Low1 low { get; set; }
        public High1 high { get; set; }
        public Numberofanalysts1 numberOfAnalysts { get; set; }
        public Yearagorevenue yearAgoRevenue { get; set; }
        public Growth3 growth { get; set; }
    }

    public class Avg1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Low1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class High1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Numberofanalysts1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Yearagorevenue
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Growth3
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Epstrend
    {
        public Current current { get; set; }
        public _7Daysago _7daysAgo { get; set; }
        public _30Daysago _30daysAgo { get; set; }
        public _60Daysago _60daysAgo { get; set; }
        public _90Daysago _90daysAgo { get; set; }
    }

    public class Current
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class _7Daysago
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class _30Daysago
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class _60Daysago
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class _90Daysago
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Epsrevisions
    {
        public Uplast7days upLast7days { get; set; }
        public Uplast30days upLast30days { get; set; }
        public Downlast30days downLast30days { get; set; }
        public Downlast90days downLast90days { get; set; }
    }

    public class Uplast7days
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Uplast30days
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Downlast30days
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Downlast90days
    {
    }

    public class Financialdata
    {
        public int maxAge { get; set; }
        public Currentprice currentPrice { get; set; }
        public Targethighprice targetHighPrice { get; set; }
        public Targetlowprice targetLowPrice { get; set; }
        public Targetmeanprice targetMeanPrice { get; set; }
        public Targetmedianprice targetMedianPrice { get; set; }
        public Recommendationmean recommendationMean { get; set; }
        public string recommendationKey { get; set; }
        public Numberofanalystopinions numberOfAnalystOpinions { get; set; }
        public Totalcash totalCash { get; set; }
        public Totalcashpershare totalCashPerShare { get; set; }
        public Ebitda ebitda { get; set; }
        public Totaldebt totalDebt { get; set; }
        public Quickratio quickRatio { get; set; }
        public Currentratio currentRatio { get; set; }
        public Totalrevenue totalRevenue { get; set; }
        public Debttoequity debtToEquity { get; set; }
        public Revenuepershare revenuePerShare { get; set; }
        public Returnonassets returnOnAssets { get; set; }
        public Returnonequity returnOnEquity { get; set; }
        public Grossprofits grossProfits { get; set; }
        public Freecashflow freeCashflow { get; set; }
        public Operatingcashflow operatingCashflow { get; set; }
        public Earningsgrowth earningsGrowth { get; set; }
        public Revenuegrowth revenueGrowth { get; set; }
        public Grossmargins grossMargins { get; set; }
        public Ebitdamargins ebitdaMargins { get; set; }
        public Operatingmargins operatingMargins { get; set; }
        public Profitmargins profitMargins { get; set; }
    }

    public class Currentprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Targethighprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Targetlowprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Targetmeanprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Targetmedianprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Recommendationmean
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Numberofanalystopinions
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcash
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashpershare
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ebitda
    {
    }

    public class Totaldebt
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Quickratio
    {
    }

    public class Currentratio
    {
    }

    public class Totalrevenue2
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Debttoequity
    {
    }

    public class Revenuepershare
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Returnonassets
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Returnonequity
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Grossprofits
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Freecashflow
    {
    }

    public class Operatingcashflow
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earningsgrowth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Revenuegrowth
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Grossmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ebitdamargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Operatingmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Profitmargins
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

}
