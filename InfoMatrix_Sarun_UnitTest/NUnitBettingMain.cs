using InfoMatrix_Sarun;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace InfoMatrix_Sarun_UnitTest
{
    [TestFixture]
    public class NUnitBettingMain
    {
        BettingMain objBettingMain;
        public NUnitBettingMain()
        {
            objBettingMain = new BettingMain();
        }

        /// <summary>
        /// For testing Settled customer having an Unusual win
        /// </summary>
        [Test]
        public void TestSettledBetCustomer()
        {
            List<Customer> listCustomer = objBettingMain.GetSettledBetCustomerList();
            Customer customer = listCustomer.Find(x => x.IsUnusualWin);
            Assert.AreEqual(customer.CustomerId, 1);
        }

        /// <summary>
        /// For testing Combined data, whose is winning at unusual rate
        /// </summary>
        [Test]
        public void TestUnSettledBetCustomerHighRisk()
        {
            List<Combined> listCombined = objBettingMain.GetCombinedCustomerList();
            List<Combined> unsettledHighRisk = new List<Combined>(listCombined.Where(x => x.UnsettledIsHighRisk));
            Assert.AreEqual(unsettledHighRisk.FirstOrDefault().CustomerId, 1);
        }

        /// <summary>
        /// For testing Combined data, whose Unsettled amount is 1000 dollars or more
        /// </summary>
        [Test]
        public void TestUnSettledBet()
        {
            List<Combined> listCombined = objBettingMain.GetCombinedCustomerList();
            List<Combined> unsettled1000Plus = new List<Combined>(listCombined.Where(x => x.UnsettledIsAmount1000Plus));
            Assert.AreEqual(unsettled1000Plus.Count(), 6);
        }
    }
}
