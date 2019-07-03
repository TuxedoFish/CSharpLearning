using System;

namespace JobApplicationAPI.Controllers
{
    /* A class to transfer data from postgres table */
    public class JobPostingDTO
    {
        public enum JobType
        {
            Internship,
            Graduate,
            FullTime,
            Contract
        }

        public int Id{ get; set; }
        public string Name{ get; set; }
        public JobType Type{ get; set; }
        public int requiredGPA{ get; set; }
    }
}