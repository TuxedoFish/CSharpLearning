using System;

namespace JobApplicationAPI.Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise postgres DAO
            IPostingsDAO DAO = PostgresDAO.Instance();
            // Query database for responses
            var student = new StudentController("Harry", 40.0m, "Undergraduate", DAO);
            var result = student.search();
            // Output the response
            Console.WriteLine(student.getView());
        }
    }
}
