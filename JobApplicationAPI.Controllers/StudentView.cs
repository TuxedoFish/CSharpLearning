using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplicationAPI.Controllers
{
    public class StudentView
    {
        /* Response */
        public string ResponseAsString(List<JobDTO> results, string name, string message)
        {
            string response;

            if(results is null || results.Count == 0)
            {
                response = "Sorry, " + name + " we were unable to match any jobs to you due to: " + message;
            } else
            {
                response = "Congratulations, " + name + " we found jobs that matched your profile: ";
                foreach(JobDTO job in results)
                {
                    response += job.Name + " " + job.Type+ " ; ";
                }
            }

            return response;
        }
    }
}
