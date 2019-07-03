using System;

namespace JobApplicationAPI.Controllers
{

    public enum JobType
    {
        Internship,
        Graduate,
        FullTime,
        Contract
    }

    public class JobPostingDTO
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public JobType Type{ get; set; }
        public int requiredGPA{ get; set; }
    }
}