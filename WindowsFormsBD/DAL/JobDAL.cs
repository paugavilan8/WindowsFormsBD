using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsBD.MODEL;

namespace WindowsFormsBD.DAL
{
    public class JobDAL
    {
        // Obtener todos los jobs
        public List<Job> GetAllJobs(DBConnection dbConn)
        {
            List<Job> jobs = new List<Job>();
            try
            {
                dbConn.Open();

                string sql = "SELECT job_id, job_title, min_salary, max_salary FROM jobs";

                using (SqlCommand cmd = new SqlCommand(sql, dbConn.Connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jobs.Add(new Job
                            {
                                job_id = reader.GetInt32(0),
                                job_title = reader.GetString(1),
                                min_salary = reader.IsDBNull(2) ? (decimal?)null : reader.GetDecimal(2),
                                max_salary = reader.IsDBNull(3) ? (decimal?)null : reader.GetDecimal(3)
                            });
                        }
                    }
                }
                return jobs;
            }
            catch { return new List<Job>(); }
            finally { dbConn.Close(); }
        }

        // Insertar nuevo
        public bool InsertJob(Job job, DBConnection dbConn)
        {
            try
            {
                dbConn.Open();
                string sql = "INSERT INTO jobs (job_title, min_salary, max_salary) VALUES (@title, @min, @max)";

                using (SqlCommand cmd = new SqlCommand(sql, dbConn.Connection))
                {
                    cmd.Parameters.AddWithValue("@title", job.job_title);
                    cmd.Parameters.AddWithValue("@min", (object)job.min_salary ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@max", (object)job.max_salary ?? DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
            finally { dbConn.Close(); }
        }

        // Actualizar
        public bool UpdateJob(Job job, DBConnection dbConn)
        {
            try
            {
                dbConn.Open();
                string sql = "UPDATE jobs SET job_title=@title, min_salary=@min, max_salary=@max WHERE job_id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, dbConn.Connection))
                {
                    cmd.Parameters.AddWithValue("@title", job.job_title);
                    cmd.Parameters.AddWithValue("@min", (object)job.min_salary ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@max", (object)job.max_salary ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", job.job_id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
            finally { dbConn.Close(); }
        }
    }
}