using System;
using System.Collections.Generic;
using Npgsql;

namespace JobApplicationAPI.Controllers
{
    public interface IPostingsDAO
    {
        JobDTO[] SelectPostsFor(Student application);
    }

    public class PostgresDAO : IPostingsDAO
    {
        private static PostgresDAO _instance;

        private static string connString = "Host=localhost:5431;Username=root;Password=password;Database=jobs";

        protected PostgresDAO()
        {  
        }

        public static PostgresDAO Instance()
        {
            if(_instance == null)
            {
                _instance = new PostgresDAO();
            }
            return _instance;
        }

        public List<JobDTO> SelectPostsFor(Student application)
        {
            List<JobDTO> postings = new List<JobDTO>();

            var jobMappings = new Dictionary<string, string[]>();
            jobMappings.Add("Undergraduate", new string[] { "Internship", "Graduate Job" } );
            jobMappings.Add("Postgraduate", new string[] { "Graduate Job", "Full Time" } );
            jobMappings.Add("Professional", new string[] { "Full Time" } );

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                /* Select the job postings from the database
                 * query is based on the education level*/

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string command = "SELECT * FROM job_postings WHERE job_type IN (";

                    var jobTypes = jobMappings[application.EducationLevel];
                    foreach (var value in jobTypes)
                    {
                        command += "'" + value + "'";
                    }

                    command += ");";

                    cmd.CommandText = command;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        postings.Add(new JobDTO((string)reader[0], (string)reader[1], (double)reader[2]));
                    }

                    conn.Close();
                }
            }

            return postings;
        }
    }
}
