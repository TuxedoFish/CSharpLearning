using System;
using Xunit;

namespace JobApplicationAPI.Tests
{
    public class InitialScanTests
    {
        /*
         * Tests the screening process
         */
        [Theory]
        [InlineData(0, "Harry", 4.0, 0, true)]
        [InlineData(0, "; DROP TABLE jobs;", -1, 5, false)]
        public void TestRequest(int id, string name, double GPA, int education, bool response)
        {
            
        }
    }
}
