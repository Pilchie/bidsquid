using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using bidsquid_web.Models;
using Xunit;

namespace bidsquid_test
{
    public class AuctionViewModelTests
    {
        [Fact]
        public void TestConstruction()
        {
            const string tagLine = "Fun times at KCDC";
            var auction = new AuctionViewModel(new DateTime(2017, 08, 02), tagLine);
            Assert.Equal(DateTime.Today, auction.Date);
            Assert.Equal(tagLine, auction.TagLine);
        }
    }
}
