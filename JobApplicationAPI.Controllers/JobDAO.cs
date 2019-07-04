using System;

namespace JobApplicationAPI.Controllers
{
    /* Having passed preliminary tests the search handler
     * now looks through a table to look for suitable posts.
       Trying to employ the "Open - Closed principle" */ 
    public abstract class JobDAO
    {
        public abstract JobDTO[] SelectPostsFor(Student application);
    }
    /* Searches through all the postings that are contained
       within a postgres database of job postings*/
    public class PostgresJobDAO : JobDAO
    {
        public override JobDTO[] SelectPostsFor(Student application)
        {
            throw new NotImplementedException();
        }
    }
}
