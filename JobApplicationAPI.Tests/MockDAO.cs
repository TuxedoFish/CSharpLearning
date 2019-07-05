using System;
using System.Collections.Generic;
using System.Text;
using JobApplicationAPI.Controllers;

namespace JobApplicationAPI.Tests
{
    class MockDAO : IPostingsDAO
    {
        public MockDAO()
        {
        }

        public List<JobDTO> SelectPostsFor(Student application)
        {
            return SelectForStudentType(application.EducationLevel);
        }

        /* Mimics the return values from the database
         * where you query for type in ( type1, type2, ... )*/
        public static List<JobDTO> SelectForStudentType(string educationLevel)
        {
            switch(educationLevel)
            {
                case "Undergraduate":
                    return new List<JobDTO>() {
                    new JobDTO("Software Engineering", "Internship", 40.0m),
                    new JobDTO("Software Engineering", "Graduate Job", 60.0m),
                    new JobDTO("Product Management", "Internship", 40.0m) };
                    break;

                case "Postgraduate":
                    return new List<JobDTO>() {
                    new JobDTO("Product Management", "Full Time", 80.0m),
                    new JobDTO("Software Engineering", "Graduate Job", 60.0m) };
                    break;

                case "Professional":
                    return new List<JobDTO>() {
                    new JobDTO("Product Management", "Full Time", 80.0m) };
                    break;

                default:
                    return new List<JobDTO>();

            }
        }

    }
}
