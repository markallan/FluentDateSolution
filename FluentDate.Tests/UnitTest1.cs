using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentDate;

namespace FluentDate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Calendar_Units()
        {
            DateTime assessmentDate = DateTime.Now;
            Assert.IsFalse(assessmentDate.Is(-9).Days.Ago);
        }


        [TestMethod]
        public void IsMoreThan_Days_Before_Today()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Today;
            Assert.IsTrue(assessmentDate.IsMoreThan(9).Days.Before(target), "9 Days before.");
            Assert.IsFalse(assessmentDate.IsMoreThan(10).Days.Before(target), "Exactly 10 Days before.");
            Assert.IsFalse(assessmentDate.IsMoreThan(11).Days.Before(target), "11 Days before.");

            assessmentDate = DateTime.Today.AddDays(2);
            Assert.IsFalse(assessmentDate.IsMoreThan(2).Days.Before(target), "11 Days before.");
        }

        [TestMethod]
        public void IsMoreThan_Days_Before_Now()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Now;
            Assert.IsTrue(assessmentDate.IsMoreThan(9).Days.Before(target), "9 Days before.");
            Assert.IsTrue(assessmentDate.IsMoreThan(10).Days.Before(target), "Assessment date is at midnight therefore it should be more than 10 days from DateTime.Now");
            Assert.IsFalse(assessmentDate.IsMoreThan(11).Days.Before(target), "11 Days before."); 
        }

        [TestMethod]
        public void IsLessThan_Days_Before_Today()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Today;
            Assert.IsFalse(assessmentDate.IsLessThan(9).Days.Before(target), "9 Days before.");
            Assert.IsFalse(assessmentDate.IsLessThan(10).Days.Before(target), "Exactly 10 Days before.");
            Assert.IsTrue(assessmentDate.IsLessThan(11).Days.Before(target), "11 Days before.");

            assessmentDate = DateTime.Today.AddDays(2);
            Assert.IsFalse(assessmentDate.IsLessThan(2).Days.Before(target), "Assessment Date is 2 days after Today.");
            Assert.IsFalse(assessmentDate.IsLessThan(1).Days.Before(target), "Assessment Date is 1 days after Today.");
            Assert.IsFalse(assessmentDate.IsLessThan(3).Days.Before(target), "Assessment Date is 3 days after Today.");
        }

        [TestMethod]
        public void IsLessThan_Days_Before_Now()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Now;
            Assert.IsTrue(assessmentDate.IsMoreThan(9).Days.Before(target), "9 Days before.");
            Assert.IsTrue(assessmentDate.IsMoreThan(10).Days.Before(target), "Assessment date is at midnight therefore it should be more than 10 days from DateTime.Now");
            Assert.IsFalse(assessmentDate.IsMoreThan(11).Days.Before(target), "11 Days before.");
        }


        [TestMethod]
        public void Is_Days_Before_Today()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Today;
            Assert.IsFalse(assessmentDate.Is(9).Days.Before(target), "9 Days before.");
            Assert.IsTrue(assessmentDate.Is(10).Days.Before(target), "Exactly 10 Days before.");
            Assert.IsFalse(assessmentDate.Is(11).Days.Before(target), "11 Days before.");

            assessmentDate = DateTime.Today.AddDays(2);
            Assert.IsFalse(assessmentDate.Is(2).Days.Before(target), "Assessment Date is 2 days after Today.");
            Assert.IsFalse(assessmentDate.Is(1).Days.Before(target), "Assessment Date is 1 days after Today.");
            Assert.IsFalse(assessmentDate.Is(3).Days.Before(target), "Assessment Date is 3 days after Today.");
        }

        [TestMethod]
        public void Is_Days_After_Today()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Today;
            Assert.IsFalse(assessmentDate.Is(9).Days.After(target), "9 Days before.");
            Assert.IsFalse(assessmentDate.Is(10).Days.After(target), "Exactly 10 Days before.");
            Assert.IsFalse(assessmentDate.Is(11).Days.After(target), "11 Days before.");

            assessmentDate = DateTime.Today.AddDays(10);
            Assert.IsFalse(assessmentDate.Is(12).Days.After(target), "Assessment Date is 12 days after Today.");
            Assert.IsTrue(assessmentDate.Is(10).Days.After(target), "Assessment Date is 10 days after Today.");
            Assert.IsFalse(assessmentDate.Is(9).Days.After(target), "Assessment Date is 9 days after Today.");
        }

        [TestMethod]
        public void IsAtLeast_Days_After_Today()
        {
            var assessmentDate = DateTime.Today.AddDays(-10);
            var target = DateTime.Today;
            Assert.IsFalse(assessmentDate.IsAtLeast(9).Days.After(target), "9 Days before.");
            Assert.IsFalse(assessmentDate.IsAtLeast(10).Days.After(target), "Exactly 10 Days before.");
            Assert.IsFalse(assessmentDate.IsAtLeast(11).Days.After(target), "11 Days before.");

            assessmentDate = DateTime.Today.AddDays(10);
            Assert.IsFalse(assessmentDate.IsAtLeast(12).Days.After(target), "Assessment Date is 12 days after Today.");
            Assert.IsTrue(assessmentDate.IsAtLeast(10).Days.After(target), "Assessment Date is 10 days after Today.");
            Assert.IsTrue(assessmentDate.IsAtLeast(9).Days.After(target), "Assessment Date is 9 days after Today.");
        }

        
    }
}
