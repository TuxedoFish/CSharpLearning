using System;

namespace JobApplicationAPI.Controllers
{
    public abstract class JobApplicationData
    {  
        public enum EducationStatus
        {
            UnderGrad,
            PostGrad,
            Professional
        }
        public JobApplicationData(int Id, string Name, decimal GPA) {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
        public int Id{ get; set; }
        public string Name{ get; set; }
        public decimal GPA{ get; set; }
        public abstract EducationStatus getEducationStatus();
        public abstract bool sendJobPostings();
        public abstract bool handleResponse(JobResponse response);
    }

    public class UnderGradJobApplicationData : JobApplicationData
    {
         public UnderGradJobApplicationData(int Id, string Name, decimal GPA) : base(Id, Name, GPA){
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
        public override EducationStatus getEducationStatus() {
            throw new NotImplementedException();
        }
        public override bool sendJobPostings() {
            throw new NotImplementedException();
        }
        public override bool handleResponse(JobResponse response) {
            throw new NotImplementedException();
        }
    }
    public class PostGradJobApplicationData : JobApplicationData
    {
         public PostGradJobApplicationData(int Id, string Name, decimal GPA) : base(Id, Name, GPA) {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
        public override EducationStatus getEducationStatus() {
            throw new NotImplementedException();
        }
        public override bool sendJobPostings() {
            throw new NotImplementedException();
        }
        public override bool handleResponse(JobResponse response) {
            throw new NotImplementedException();
        }
    }
    public class ProfessionalJobApplicationData : JobApplicationData
    {
         public ProfessionalJobApplicationData(int Id, string Name, decimal GPA) : base(Id, Name, GPA) {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
        public override EducationStatus getEducationStatus() {
            throw new NotImplementedException();
        }
        public override bool sendJobPostings() {
            throw new NotImplementedException();
        }
        public override bool handleResponse(JobResponse response) {
            throw new NotImplementedException();
        }
    }
}
