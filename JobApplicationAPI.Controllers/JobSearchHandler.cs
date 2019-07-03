using System;

namespace JobApplicationAPI.Controllers
{
    /* Having passed preliminary tests the search handler
     * now looks through a table to look for suitable posts.
       Trying to employ the "Open - Closed principle" */ 
    public abstract class JobSearchHandler
    {
        public abstract JobApplicationAPI.Controllers.JobPostingDTO[] findJobPosts(JobApplicationData application);
    }
    /* Searches through all the postings that are contained
       within a postgres database of job postings*/
    public class JobOnlineSearchHandler : JobSearchHandler
    {
        public override JobApplicationAPI.Controllers.JobPostingDTO[] findJobPosts(JobApplicationData application)
        {
            throw new NotImplementedException();
        }
    }
}
