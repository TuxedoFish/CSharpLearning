using System;

namespace JobApplicationAPI.Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = searchForJobs(0, "Harry", 4.0, 0);
            Console.WriteLine(output);
        }
        /* Mocks up the endpoint for searching#
         * education passed as an integer and then
           mapped to an enum inside of JobApplicationData */
        static string searchForJobs(int id, string name, double GPA, int education)
        {
            /* Set up using information passed from the request */
            JobApplicationData user = new JobApplicationData(id, name, GPA, education);

            JobApplicationHandler checker = new JobApplicationHandlerChecker();
            JobApplicationHandler eligibility = new JobApplicationHandlerEligibility();

            checker.setSuccessor(eligibility);

            JobSearchHandler search = new JobOnlineSearchHandler();

            String response;

            /* Initial screen */
            if(checker.handleJobRequest(user))
            {
                /* Passed the initial tests so carry on to fetch results */
                JobPostingDTO[] results = search.findJobPosts(user);

                response = ResponseBuilder.success(results);
            } else
            {
                /* Failed the initial tests so send a request back to the front end */
                response = ResponseBuilder.failure();
            }

            return response;
        }
    }
}
