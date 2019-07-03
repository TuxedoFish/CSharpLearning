using System;

namespace JobApplicationAPI.Controllers
{
    /* A class to store the input sent through from the front end */
    public class JobApplicationData
    {  
        public enum EducationStatus
        {
            UnderGrad = 0,
            PostGrad = 1,
            Professional = 2
        }
        public JobApplicationData(int Id, string Name, double GPA, int education) {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
            this.education = (EducationStatus) education;
        }
        public int Id{ get; set; }
        public string Name{ get; set; }
        public double GPA{ get; set; }
        public EducationStatus education { get; set; }
    }
}
