using WindowsFormsBD.DAL;
using WindowsFormsBD.MODEL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class FormPrincipal : Form
    {
        private DBConnection dbConn;
        private Job selectedJob;

        public FormPrincipal()
        {
            InitializeComponent();
            dbConn = new DBConnection();
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn.Open();
                labMessage.Text = "Conexión OK!";
                butOpen.Enabled = false;
                butClose.Enabled = true;
            }
            catch (Exception)
            {
                labMessage.Text = "Fallo en la conexión!";
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn.Close();
                labMessage.Text = "Conexión cerrada";
                butOpen.Enabled = true;
                butClose.Enabled = false;
            }
            catch (Exception)
            {
                labMessage.Text = "Fallo al cerrar!";
            }
        }

        private Job LeerJob()
        {
            string title = txtTitle.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Introduzca el título del puesto.");
                return null;
            }

            decimal valorLeido;
            decimal? minSalary = null;
            decimal? maxSalary = null;

            if (!string.IsNullOrWhiteSpace(txtMin.Text))
            {
                if (decimal.TryParse(txtMin.Text, out valorLeido))
                    minSalary = valorLeido;
                else
                {
                    MessageBox.Show("Salario mínimo no es un número válido.");
                    return null;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtMax.Text))
            {
                if (decimal.TryParse(txtMax.Text, out valorLeido))
                    maxSalary = valorLeido;
                else
                {
                    MessageBox.Show("Salario máximo no es un número válido.");
                    return null;
                }
            }

            return new Job()
            {
                job_title = title,
                min_salary = minSalary,
                max_salary = maxSalary
            };
        }

        private void butInsertV4_Click(object sender, EventArgs e)
        {
            Job j = LeerJob();
            if (j == null)
            {
                MessageBox.Show("Error en los datos del puesto.");
                return;
            }

            JobDAL jobDAL = new JobDAL();

            if (!jobDAL.InsertJob(j, dbConn))
                MessageBox.Show("Error al insertar el puesto.");
            else
                MessageBox.Show("Puesto insertado correctamente.");
        }

        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJob = listBoxJobs.SelectedItem as Job;
            if (selectedJob != null)
            {
                txtTitle.Text = selectedJob.job_title;
                txtMin.Text = selectedJob.min_salary?.ToString() ?? "";
                txtMax.Text = selectedJob.max_salary?.ToString() ?? "";
            }
        }

        private void buttonGetJobs_Click(object sender, EventArgs e)
        {
            listBoxJobs.Items.Clear();

            JobDAL dal = new JobDAL();
            var jobs = dal.GetAllJobs(dbConn);
            foreach (var job in jobs)
            {
                listBoxJobs.Items.Add(job);
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedJob == null)
            {
                MessageBox.Show("Seleccione un job en la lista.");
                return;
            }

            selectedJob.job_title = txtTitle.Text.Trim();
            selectedJob.min_salary = decimal.TryParse(txtMin.Text, out decimal minVal) ? (decimal?)minVal : null;
            selectedJob.max_salary = decimal.TryParse(txtMax.Text, out decimal maxVal) ? (decimal?)maxVal : null;

            JobDAL dal = new JobDAL();
            if (dal.UpdateJob(selectedJob, dbConn))
                MessageBox.Show("Job actualizado correctamente");
            else
                MessageBox.Show("Error al actualizar.");
        }
    }
}