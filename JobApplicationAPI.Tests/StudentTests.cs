using System;
using System.Collections.Generic;
using Xunit;
using JobApplicationAPI.Controllers;
using Moq;

namespace JobApplicationAPI.Tests
{
    public class StudentTests
    {
        private Mock<PostgresDAO> DAO;

        public StudentTests()
        {
            /* Mock of the DAO */
            var jobPostings = SelectPosts();

            DAO = new Mock<PostgresDAO>();
            DAO.Setup(x => x.SelectPostsFor(It.IsAny<Student>())).Returns(jobPostings);
        }

        [Fact]
        public void TestStudentSearch()
        {
            var student = new StudentController("Harry", 40.0m, "undergraduate", DAO.Object);
            var result = student.search();
            Assert.IsType<string>(result);
        }

        [Fact]
        public void TestStudentView()
        {
            var studentView = new StudentView();
            var result = studentView.ResponseAsString(SelectPosts(), "Harry", "success");
            Assert.IsType<bool>(result);
        }

        [Theory]
        [InlineData(80, "Undergraduate", 2)]
        [InlineData(20, "Undergraduate", 0)]
        [InlineData(50, "Postgraduate", 1)]
        [InlineData(50, "Professional", 2)]
        public void TestStudentLogic(decimal averageMark, string educationLevel, int expectedResults)
        {
            var student = new StudentController("", averageMark, educationLevel, DAO.Object);
            student.search();
            var actualResults = student.getJobsFound().Count;
            Assert.Equal<int>(expectedResults, actualResults);
        }

        /* Mimics the return values from the DAO */
        private List<JobDTO> SelectPosts()
        {
            List<JobDTO> jobs = new List<JobDTO>() {
                new JobDTO("Software Engineering", "Internship", 40.0m),
                new JobDTO("Product Management", "Full Time", 80.0m),
                new JobDTO("Software Engineering", "Graduate Job", 60.0m),
                new JobDTO("Product Management", "Internship", 40.0m)
            };
            return jobs;
        }
    }
}
