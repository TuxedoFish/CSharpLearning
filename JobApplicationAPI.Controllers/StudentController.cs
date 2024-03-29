using System;
using System.Collections.Generic;

namespace JobApplicationAPI.Controllers
{
    public class StudentController
    {
        protected Student model;
        protected StudentView view;
        protected IPostingsDAO jobDAO;

        private List<JobDTO> postings;

        public StudentController(string name, decimal averageMark, string educationLevel, IPostingsDAO jobDAO)
        {
            this.model = new Student(name, averageMark, educationLevel);
            this.view = new StudentView();
            this.jobDAO = jobDAO;
        }
        public bool search()
        {
            List<JobDTO> buffer = jobDAO.SelectPostsFor(model);

            if(model.EducationLevel.Equals("Professional"))
            {
                postings = buffer;
            } else
            {
                postings = new List<JobDTO>();

                foreach (JobDTO job in buffer)
                {
                    if(model.AverageMark >= job.RequiredGrade)
                    {
                        postings.Add(job);
                    }
                }
            }

            return true;
        }
        public List<JobDTO> getJobsFound()
        {
            if(postings is null)
            {
                throw new InvalidOperationException();
            }

            return postings;
        }
        public string getView()
        {
            if (postings is null)
            {
                throw new InvalidOperationException();
            }

            return view.ResponseAsString(postings, model.Name, "unknown");
        }
    }
}