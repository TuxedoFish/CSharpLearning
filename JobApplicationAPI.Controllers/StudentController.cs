using System;

namespace JobApplicationAPI.Controllers
{
    public class StudentController
    {
        protected Student model;
        protected StudentView view;
        protected PostgresDAO jobDAO;
        public StudentController(string name, double averageMark, string educationLevel, PostgresDAO jobDAO)
        {
            this.model = new Student(name, averageMark, educationLevel);
            this.view = new StudentView();
            this.jobDAO = jobDAO;
        }
        public bool search()
        {
            throw new NotImplementedException();
        }
        public string getView()
        {
            throw new NotImplementedException();
        }
        public JobDTO[] getJobsFound()
        {
            throw new NotImplementedException();
        }
    }
}