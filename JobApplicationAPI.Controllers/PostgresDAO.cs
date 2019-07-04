using System;
using System.Collections.Generic;
using Npgsql;

namespace JobApplicationAPI.Controllers
{
    public interface IPostingsDAO
    {
        List<JobDTO> SelectPostsFor(Student application);
    }

    public class PostgresDAO : IPostingsDAO
    {
        private static PostgresDAO _instance;

        private static string connString = "Server=127.0.0.1; Port=5432; Database=jobs; User Id=root; Password=password";

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

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = getQueryForEducationLevel(application.EducationLevel);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        postings.Add(new JobDTO((string)reader[0], (string)reader[1], (Decimal)reader[2]));
                    }

                    conn.Close();
                }
            }

            return postings;
        }

        private string getQueryForEducationLevel(string educationLevel)
        {
            var jobMappings = new Dictionary<string, string[]>();
            jobMappings.Add("Undergraduate", new string[] { " 'Internship' ", " 'Graduate Job' " });
            jobMappings.Add("Postgraduate", new string[] { " 'Graduate Job' ", " 'Full Time' " });
            jobMappings.Add("Professional", new string[] { " 'Full Time' " });

            var jobTypes = String.Join(",", jobMappings[educationLevel]);

            string command = "SELECT * FROM job_postings WHERE job_type IN (" + jobTypes + ");";

            return command;
        }
    }
}
