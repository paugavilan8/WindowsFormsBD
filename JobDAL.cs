using System;

namespace WindowsFormsBD.DAL
{
    public class JobDAL
    {
        public bool InsertJob(Job job, SqlConnection conn)
        {
            try
            {
                string sql = @"
                INSERT INTO jobs ([job_title], [min_salary], [max_salary])
                VALUES (@job_title, @min_salary, @max_salary)";

                using SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@job_title", job.job_title);
                sqlCommand.Parameters.AddWithValue("@min_salary", (object)job.min_salary ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@max_salary", (object)job.max_salary ?? DBNull.Value);

                int rows = sqlCommand.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}