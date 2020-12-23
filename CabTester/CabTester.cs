using CabInvoiceGenrators;
using NUnit.Framework;

namespace CabTester
{
    public class CabTesters
    {
        InvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// TC 1 Given the distance and time  return total fare.
        /// </summary>
        
        [Test]
        public void GivenDistanceAndTime_WhenInvoiceGenerator_ThenShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}