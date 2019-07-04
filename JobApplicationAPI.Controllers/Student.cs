using System;

namespace JobApplicationAPI.Controllers
{
    /* Student - Model */
    public class Student
    {  
        public Student(string name, decimal averageMark, string educationLevel) {
            this.Name = name;
            this.AverageMark = averageMark;
            this.EducationLevel = educationLevel;
        }
        public string Name{ get; private set; }
        public decimal AverageMark { get; private set; }
        public string EducationLevel { get; private set; }
    }
}
