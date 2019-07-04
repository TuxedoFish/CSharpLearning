using System;

namespace JobApplicationAPI.Controllers
{
    /* A class to transfer data from postgres table */
    public class JobDTO
    {
        public JobDTO(string name, string type, double requiredGrade)
        {
            this.Name = name;
            this.Type = type;
            this.RequiredGrade = requiredGrade;
        }
        public string Name{ get; private set; }
        public string Type{ get; private set; }
        public double RequiredGrade { get; private set; }
    }
}