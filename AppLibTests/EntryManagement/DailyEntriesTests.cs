using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLib.EntryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib.EntryManagement.Tests
{
    [TestClass]
    public class DailyEntriesTests
    {
        private readonly DailyEntries _dailyEntries = new(DateTime.Now);

        [TestMethod]
        public void DailyEntriesTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void AddEntryTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetTotalByPaymentTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ToStringTest()
        {
            string ExpectedDateTime = $"""
                Date: {DateTime.Now.ToShortDateString()}
                Count: 0
                """;

            Assert.AreEqual(_dailyEntries.ToString(), ExpectedDateTime);
        }
    }
}