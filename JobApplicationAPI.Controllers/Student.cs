using System;

namespace JobApplicationAPI.Controllers
{
    /* Student - Model */
    public class Student
    {  
        public Student(string name, double averageMark, string educationLevel) {
            this.Name = name;
            this.AverageMark = averageMark;
            this.Education = educationLevel;
        }
        public string Name{ get; private set; }
        public double AverageMark{ get; private set; }
        public string Education { get; private set; }
    }
}
