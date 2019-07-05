using System;

namespace JobApplicationAPI.Controllers
{
    /* A class to transfer data from postgres table */
    public class JobDTO
    {
        public JobDTO(string name, string type, decimal requiredGrade)
        {
            this.Name = name;
            this.Type = type;
            this.RequiredGrade = requiredGrade;
        }
        public string Name{ get; private set; }
        public string Type{ get; private set; }
        public decimal RequiredGrade { get; private set; }
    }
}