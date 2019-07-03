using System;

namespace JobApplicationAPI.Controllers
{
    /* Abstract Handler */
    public abstract class JobApplicationHandler 
    {
        protected JobApplicationHandler successor;
        public void setSuccessor(JobApplicationHandler handler)
        {
            this.successor = handler;
        }
        public abstract bool handleJobRequest(JobApplicationAPI.Controllers.JobApplicationData request);
    }

    /* Concrete Handler */
    class JobApplicationHandlerChecker : JobApplicationHandler
    {
        /* Should check that the inputted text has no issues */
        public override bool handleJobRequest(JobApplicationAPI.Controllers.JobApplicationData request)
        {
            throw new NotImplementedException();
        }
    }

    /* Concrete Handler */
    class JobApplicationHandlerEligibility : JobApplicationHandler
    {
        /* Should check whether the user is eligible for application */
        public override bool handleJobRequest(JobApplicationAPI.Controllers.JobApplicationData request)
        {
            throw new NotImplementedException();
        }
    }
}