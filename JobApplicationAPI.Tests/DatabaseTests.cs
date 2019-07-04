using System;
using Xunit;
using JobApplicationAPI.Controllers;
using Moq;

namespace JobApplicationAPI.Tests
{
    public class DatabaseTests
    {
        public DatabaseTests()
        {
        }

        [Theory]
        [InlineData("Undergraduate", 2)]
        [InlineData("Postgraduate", 3)]
        [InlineData("Professional", 2)]
        public void TestDatabaseQuery(string educationLevel, int expectedCount)
        {
            var student = new Student("", 0, educationLevel);
            var DAO = PostgresDAO.Instance();
            var actualCount = DAO.SelectPostsFor(student).Count;
            Assert.Equal<int>(expectedCount, actualCount);
        }
    }
}
