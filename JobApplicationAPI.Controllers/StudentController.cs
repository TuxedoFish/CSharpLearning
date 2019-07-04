using System;

namespace JobApplicationAPI.Controllers
{
    public class StudentController
    {
        protected Student model;
        protected StudentView view;
        public StudentController(string name, double averageMark, string educationLevel)
        {
            model = new Student(name, averageMark, educationLevel);
            view = new StudentView();
        }
        public JobDTO[] SearchJobs()
        {
            throw new NotImplementedException();
        }
    }
}