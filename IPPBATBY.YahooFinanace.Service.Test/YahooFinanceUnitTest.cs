using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.IO;


using IPPBATBY.YahooFinance.Service;
using IPPBATBY.Twitter.Service;

namespace IPPBATBY.YahooFinance.Service.Test
{
    [TestClass]
    public class UnitTest1
    {

        public YahooFinanceService yahooFinanceService { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            this.yahooFinanceService = new YahooFinanceService();
        }

        private async Task<string> GetCurrentPriceAsync()
        {
            string myCurrentPrice = await yahooFinanceService.GetCurrentPrice();
            Assert.IsNotNull(myCurrentPrice);
            //Assert.IsTrue(myCurrentPrice > 0, "Current Price is not more than zero.");
            return myCurrentPrice;
        
        }

        [TestMethod]
        public async Task Can_Get_CurrentPrice()
        {
            string price = await this.GetCurrentPriceAsync();
        }

    }
}
