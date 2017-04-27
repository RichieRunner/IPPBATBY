using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IPPBATBY.Service
{

    public class FinancialData
    {
        [JsonProperty("quoteSummary")]
        public Quotesummary quoteSummary1 { get; set; }
    }

    public class Quotesummary
    {
        public Result[] result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public Cashflowstatementhistoryquarterly cashflowStatementHistoryQuarterly { get; set; }
        public Cashflowstatementhistory cashflowStatementHistory { get; set; }
        public Incomestatementhistoryquarterly incomeStatementHistoryQuarterly { get; set; }
        public Earnings earnings { get; set; }
        public Balancesheethistoryquarterly balanceSheetHistoryQuarterly { get; set; }
        public Balancesheethistory balanceSheetHistory { get; set; }
        public Incomestatementhistory1 incomeStatementHistory { get; set; }
    }

    public class Cashflowstatementhistoryquarterly
    {
        public Cashflowstatement[] cashflowStatements { get; set; }
        public int maxAge { get; set; }
    }

    public class Cashflowstatement
    {
        public int maxAge { get; set; }
        public Enddate endDate { get; set; }
        public Netincome netIncome { get; set; }
        public Depreciation depreciation { get; set; }
        public Changetonetincome changeToNetincome { get; set; }
        public Changetoaccountreceivables changeToAccountReceivables { get; set; }
        public Changetoliabilities changeToLiabilities { get; set; }
        public Changetooperatingactivities changeToOperatingActivities { get; set; }
        public Totalcashfromoperatingactivities totalCashFromOperatingActivities { get; set; }
        public Capitalexpenditures capitalExpenditures { get; set; }
        public Investments investments { get; set; }
        public Othercashflowsfrominvestingactivities otherCashflowsFromInvestingActivities { get; set; }
        public Totalcashflowsfrominvestingactivities totalCashflowsFromInvestingActivities { get; set; }
        public Salepurchaseofstock salePurchaseOfStock { get; set; }
        public Netborrowings netBorrowings { get; set; }
        public Othercashflowsfromfinancingactivities otherCashflowsFromFinancingActivities { get; set; }
        public Totalcashfromfinancingactivities totalCashFromFinancingActivities { get; set; }
        public Changeincash changeInCash { get; set; }
    }

    public class Enddate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Netincome
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Depreciation
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetonetincome
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetoaccountreceivables
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetoliabilities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetooperatingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashfromoperatingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Capitalexpenditures
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Investments
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercashflowsfrominvestingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashflowsfrominvestingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Salepurchaseofstock
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netborrowings
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercashflowsfromfinancingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashfromfinancingactivities
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changeincash
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Cashflowstatementhistory
    {
        public Cashflowstatement1[] cashflowStatements { get; set; }
        public int maxAge { get; set; }
    }

    public class Cashflowstatement1
    {
        public int maxAge { get; set; }
        public Enddate1 endDate { get; set; }
        public Netincome1 netIncome { get; set; }
        public Depreciation1 depreciation { get; set; }
        public Changetonetincome1 changeToNetincome { get; set; }
        public Changetoaccountreceivables1 changeToAccountReceivables { get; set; }
        public Changetoliabilities1 changeToLiabilities { get; set; }
        public Changetooperatingactivities1 changeToOperatingActivities { get; set; }
        public Totalcashfromoperatingactivities1 totalCashFromOperatingActivities { get; set; }
        public Capitalexpenditures1 capitalExpenditures { get; set; }
        public Investments1 investments { get; set; }
        public Othercashflowsfrominvestingactivities1 otherCashflowsFromInvestingActivities { get; set; }
        public Totalcashflowsfrominvestingactivities1 totalCashflowsFromInvestingActivities { get; set; }
        public Salepurchaseofstock1 salePurchaseOfStock { get; set; }
        public Netborrowings1 netBorrowings { get; set; }
        public Othercashflowsfromfinancingactivities1 otherCashflowsFromFinancingActivities { get; set; }
        public Totalcashfromfinancingactivities1 totalCashFromFinancingActivities { get; set; }
        public Changeincash1 changeInCash { get; set; }
    }

    public class Enddate1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Netincome1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Depreciation1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetonetincome1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetoaccountreceivables1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetoliabilities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changetooperatingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashfromoperatingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Capitalexpenditures1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Investments1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercashflowsfrominvestingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashflowsfrominvestingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Salepurchaseofstock1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netborrowings1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercashflowsfromfinancingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalcashfromfinancingactivities1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Changeincash1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incomestatementhistoryquarterly
    {
        public Incomestatementhistory[] incomeStatementHistory { get; set; }
        public int maxAge { get; set; }
    }

    public class Incomestatementhistory
    {
        public int maxAge { get; set; }
        public Enddate2 endDate { get; set; }
        public Totalrevenue totalRevenue { get; set; }
        public Costofrevenue costOfRevenue { get; set; }
        public Grossprofit grossProfit { get; set; }
        public Researchdevelopment researchDevelopment { get; set; }
        public Sellinggeneraladministrative sellingGeneralAdministrative { get; set; }
        public Nonrecurring nonRecurring { get; set; }
        public Otheroperatingexpenses otherOperatingExpenses { get; set; }
        public Totaloperatingexpenses totalOperatingExpenses { get; set; }
        public Operatingincome operatingIncome { get; set; }
        public Totalotherincomeexpensenet totalOtherIncomeExpenseNet { get; set; }
        public Ebit ebit { get; set; }
        public Interestexpense interestExpense { get; set; }
        public Incomebeforetax incomeBeforeTax { get; set; }
        public Incometaxexpense incomeTaxExpense { get; set; }
        public Minorityinterest minorityInterest { get; set; }
        public Netincomefromcontinuingops netIncomeFromContinuingOps { get; set; }
        public Discontinuedoperations discontinuedOperations { get; set; }
        public Extraordinaryitems extraordinaryItems { get; set; }
        public Effectofaccountingcharges effectOfAccountingCharges { get; set; }
        public Otheritems otherItems { get; set; }
        public Netincome2 netIncome { get; set; }
        public Netincomeapplicabletocommonshares netIncomeApplicableToCommonShares { get; set; }
    }

    public class Enddate2
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Totalrevenue
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Costofrevenue
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Grossprofit
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Researchdevelopment
    {
    }

    public class Sellinggeneraladministrative
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Nonrecurring
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otheroperatingexpenses
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totaloperatingexpenses
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Operatingincome
    {
    }

    public class Totalotherincomeexpensenet
    {
    }

    public class Ebit
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Interestexpense
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incomebeforetax
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incometaxexpense
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Minorityinterest
    {
    }

    public class Netincomefromcontinuingops
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Discontinuedoperations
    {
    }

    public class Extraordinaryitems
    {
    }

    public class Effectofaccountingcharges
    {
    }

    public class Otheritems
    {
    }

    public class Netincome2
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netincomeapplicabletocommonshares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earnings
    {
        public int maxAge { get; set; }
        public Earningschart earningsChart { get; set; }
        public Financialschart financialsChart { get; set; }
    }

    public class Earningschart
    {
        public Quarterly[] quarterly { get; set; }
        public Currentquarterestimate currentQuarterEstimate { get; set; }
        public string currentQuarterEstimateDate { get; set; }
        public int currentQuarterEstimateYear { get; set; }
    }

    public class Currentquarterestimate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Quarterly
    {
        public string date { get; set; }
        public Actual actual { get; set; }
        public Estimate estimate { get; set; }
    }

    public class Actual
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Estimate
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Financialschart
    {
        public Yearly[] yearly { get; set; }
        public Quarterly1[] quarterly { get; set; }
    }

    public class Yearly
    {
        public int date { get; set; }
        public Revenue revenue { get; set; }
        public Earnings1 earnings { get; set; }
    }

    public class Revenue
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earnings1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Quarterly1
    {
        public string date { get; set; }
        public Revenue1 revenue { get; set; }
        public Earnings2 earnings { get; set; }
    }

    public class Revenue1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Earnings2
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Balancesheethistoryquarterly
    {
        public Balancesheetstatement[] balanceSheetStatements { get; set; }
        public int maxAge { get; set; }
    }

    public class Balancesheetstatement
    {
        public int maxAge { get; set; }
        public Enddate3 endDate { get; set; }
        public Cash cash { get; set; }
        public Netreceivables netReceivables { get; set; }
        public Longterminvestments longTermInvestments { get; set; }
        public Propertyplantequipment propertyPlantEquipment { get; set; }
        public Goodwill goodWill { get; set; }
        public Intangibleassets intangibleAssets { get; set; }
        public Otherassets otherAssets { get; set; }
        public Deferredlongtermassetcharges deferredLongTermAssetCharges { get; set; }
        public Totalassets totalAssets { get; set; }
        public Accountspayable accountsPayable { get; set; }
        public Shortlongtermdebt shortLongTermDebt { get; set; }
        public Othercurrentliab otherCurrentLiab { get; set; }
        public Totalliab totalLiab { get; set; }
        public Commonstock commonStock { get; set; }
        public Retainedearnings retainedEarnings { get; set; }
        public Capitalsurplus capitalSurplus { get; set; }
        public Otherstockholderequity otherStockholderEquity { get; set; }
        public Totalstockholderequity totalStockholderEquity { get; set; }
        public Nettangibleassets netTangibleAssets { get; set; }
    }

    public class Enddate3
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Cash
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netreceivables
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Longterminvestments
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Propertyplantequipment
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Goodwill
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Intangibleassets
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otherassets
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Deferredlongtermassetcharges
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalassets
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Accountspayable
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Shortlongtermdebt
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercurrentliab
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalliab
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Commonstock
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Retainedearnings
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Capitalsurplus
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otherstockholderequity
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalstockholderequity
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Nettangibleassets
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Balancesheethistory
    {
        public Balancesheetstatement1[] balanceSheetStatements { get; set; }
        public int maxAge { get; set; }
    }

    public class Balancesheetstatement1
    {
        public int maxAge { get; set; }
        public Enddate4 endDate { get; set; }
        public Cash1 cash { get; set; }
        public Netreceivables1 netReceivables { get; set; }
        public Longterminvestments1 longTermInvestments { get; set; }
        public Propertyplantequipment1 propertyPlantEquipment { get; set; }
        public Goodwill1 goodWill { get; set; }
        public Intangibleassets1 intangibleAssets { get; set; }
        public Otherassets1 otherAssets { get; set; }
        public Deferredlongtermassetcharges1 deferredLongTermAssetCharges { get; set; }
        public Totalassets1 totalAssets { get; set; }
        public Accountspayable1 accountsPayable { get; set; }
        public Shortlongtermdebt1 shortLongTermDebt { get; set; }
        public Othercurrentliab1 otherCurrentLiab { get; set; }
        public Totalliab1 totalLiab { get; set; }
        public Commonstock1 commonStock { get; set; }
        public Retainedearnings1 retainedEarnings { get; set; }
        public Capitalsurplus1 capitalSurplus { get; set; }
        public Otherstockholderequity1 otherStockholderEquity { get; set; }
        public Totalstockholderequity1 totalStockholderEquity { get; set; }
        public Nettangibleassets1 netTangibleAssets { get; set; }
    }

    public class Enddate4
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Cash1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netreceivables1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Longterminvestments1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Propertyplantequipment1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Goodwill1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Intangibleassets1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otherassets1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Deferredlongtermassetcharges1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalassets1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Accountspayable1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Shortlongtermdebt1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Othercurrentliab1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalliab1
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Commonstock1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Retainedearnings1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Capitalsurplus1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otherstockholderequity1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totalstockholderequity1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Nettangibleassets1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incomestatementhistory1
    {
        public Incomestatementhistory2[] incomeStatementHistory { get; set; }
        public int maxAge { get; set; }
    }

    public class Incomestatementhistory2
    {
        public int maxAge { get; set; }
        public Enddate5 endDate { get; set; }
        public Totalrevenue1 totalRevenue { get; set; }
        public Costofrevenue1 costOfRevenue { get; set; }
        public Grossprofit1 grossProfit { get; set; }
        public Researchdevelopment1 researchDevelopment { get; set; }
        public Sellinggeneraladministrative1 sellingGeneralAdministrative { get; set; }
        public Nonrecurring1 nonRecurring { get; set; }
        public Otheroperatingexpenses1 otherOperatingExpenses { get; set; }
        public Totaloperatingexpenses1 totalOperatingExpenses { get; set; }
        public Operatingincome1 operatingIncome { get; set; }
        public Totalotherincomeexpensenet1 totalOtherIncomeExpenseNet { get; set; }
        public Ebit1 ebit { get; set; }
        public Interestexpense1 interestExpense { get; set; }
        public Incomebeforetax1 incomeBeforeTax { get; set; }
        public Incometaxexpense1 incomeTaxExpense { get; set; }
        public Minorityinterest1 minorityInterest { get; set; }
        public Netincomefromcontinuingops1 netIncomeFromContinuingOps { get; set; }
        public Discontinuedoperations1 discontinuedOperations { get; set; }
        public Extraordinaryitems1 extraordinaryItems { get; set; }
        public Effectofaccountingcharges1 effectOfAccountingCharges { get; set; }
        public Otheritems1 otherItems { get; set; }
        public Netincome3 netIncome { get; set; }
        public Netincomeapplicabletocommonshares1 netIncomeApplicableToCommonShares { get; set; }
    }

    public class Enddate5
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Totalrevenue1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Costofrevenue1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Grossprofit1
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Researchdevelopment1
    {
    }

    public class Sellinggeneraladministrative1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Nonrecurring1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Otheroperatingexpenses1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Totaloperatingexpenses1
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Operatingincome1
    {
    }

    public class Totalotherincomeexpensenet1
    {
    }

    public class Ebit1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Interestexpense1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incomebeforetax1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Incometaxexpense1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Minorityinterest1
    {
    }

    public class Netincomefromcontinuingops1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Discontinuedoperations1
    {
    }

    public class Extraordinaryitems1
    {
    }

    public class Effectofaccountingcharges1
    {
    }

    public class Otheritems1
    {
    }

    public class Netincome3
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Netincomeapplicabletocommonshares1
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

}
