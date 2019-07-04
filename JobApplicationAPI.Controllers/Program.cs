using System;

namespace JobApplicationAPI.Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = SearchForJobs("Harry", 4.0, "undergraduate");
            Console.WriteLine(output);
        }
        /* Mocks up the endpoint for searching#
         * education passed as an integer and then
           mapped to an enum inside of JobApplicationData */
        static string SearchForJobs(string name, double GPA, string education)
        {
            /* Set up using information passed from the request */
            var student = new Student(name, GPA, education);
            var search = new PostgresJobDAO();
            return "Error";
        }
    }
}
