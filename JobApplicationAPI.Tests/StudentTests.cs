using System;
using System.Collections.Generic;
using Xunit;
using JobApplicationAPI.Controllers;
using Moq;

namespace JobApplicationAPI.Tests
{
    public class StudentTests
    {
        private MockDAO DAO;

        public StudentTests()
        {
            /* Mock of the DAO */
            DAO = new MockDAO();
        }

        [Fact]
        public void TestStudentSearch()
        {
            var student = new StudentController("Harry", 40.0m, "Undergraduate", DAO);
            var result = student.search();
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void TestStudentView()
        {
            var studentView = new StudentView();
            var result = studentView.ResponseAsString(MockDAO.SelectForStudentType("Undergraduate"), "Name", "Test");
            Assert.IsType<string>(result);
        }

        [Theory]
        [InlineData(80, "Undergraduate", 3)]
        [InlineData(20, "Undergraduate", 0)]
        [InlineData(50, "Postgraduate", 0)]
        [InlineData(50, "Professional", 1)]
        public void TestStudentLogic(decimal averageMark, string educationLevel, int expectedResults)
        {
            var student = new StudentController("", averageMark, educationLevel, DAO);
            student.search();
            var actualResults = student.getJobsFound().Count;
            Assert.Equal<int>(expectedResults, actualResults);
        }
    }
}
