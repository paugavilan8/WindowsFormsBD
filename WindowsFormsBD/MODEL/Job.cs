using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD.MODEL
{
    public class Job
    {
        public int job_id { get; set; }
        public string job_title { get; set; }
        public decimal? min_salary { get; set; }
        public decimal? max_salary { get; set; }

        public override string ToString()
        {
            return $"{job_title} - Min: {(min_salary.HasValue ? min_salary.Value.ToString("F2") : "N/A")} - Max: {(max_salary.HasValue ? max_salary.Value.ToString("F2") : "N/A")}";
        }
    }
}
