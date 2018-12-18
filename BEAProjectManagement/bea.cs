using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    class bea
    {
        static public int userID;
        static public int userRole;
        static public string userFullName;
        static public string currentProject;
        static public string currentPerson;
        static public string currentActivity;

        static public Tuple<int, int> GetProjectAvailableHours(int projectID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectAvailableHours2";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@projID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = projectID;

            SqlParameter pActivitiesAvailable = new SqlParameter();
            pActivitiesAvailable = command.Parameters.Add("@availableFromAvtivities", SqlDbType.Int);
            pActivitiesAvailable.Direction = ParameterDirection.Output;
            pActivitiesAvailable.Value = 0;


            SqlParameter pPersonsAvailable = new SqlParameter();
            pPersonsAvailable = command.Parameters.Add("@availableFromPersons", SqlDbType.Int);
            pPersonsAvailable.Direction = ParameterDirection.Output;
            pPersonsAvailable.Value = 0;
                        
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
            return Tuple.Create((int)pActivitiesAvailable.Value, (int)pPersonsAvailable.Value);

        }

        static public string GetCurrentProject(int projectID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectTitle";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pProject = new SqlParameter();
            pProject = command.Parameters.Add("@project", SqlDbType.Int);
            pProject.Direction = ParameterDirection.Input;
            pProject.Value = projectID;

            SqlParameter pProjectTitle = new SqlParameter();
            pProjectTitle = command.Parameters.Add("@projectTitle", SqlDbType.NVarChar, 250);
            pProjectTitle.Direction = ParameterDirection.Output;
            pProjectTitle.Value = 0;           

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
            return (string)pProjectTitle.Value;
        }

        static public string GetCurrentPerson(int personID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetPersonFullName";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pPerson = new SqlParameter();
            pPerson = command.Parameters.Add("@person", SqlDbType.Int);
            pPerson.Direction = ParameterDirection.Input;
            pPerson.Value = personID;

            SqlParameter pPersonFullName = new SqlParameter();
            pPersonFullName = command.Parameters.Add("@personFullName", SqlDbType.NVarChar, 250);
            pPersonFullName.Direction = ParameterDirection.Output;
            pPersonFullName.Value = 0;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
            return (string)pPersonFullName.Value;
        }

        static public string GetCurrentActivity(int activityID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetActivityTitle";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pProject = new SqlParameter();
            pProject = command.Parameters.Add("@activity", SqlDbType.Int);
            pProject.Direction = ParameterDirection.Input;
            pProject.Value = activityID;

            SqlParameter pProjectTitle = new SqlParameter();
            pProjectTitle = command.Parameters.Add("@activityTitle", SqlDbType.NVarChar, 250);
            pProjectTitle.Direction = ParameterDirection.Output;
            pProjectTitle.Value = 0;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
            return (string)pProjectTitle.Value;
        }

        static public int GetPersonAvailableProjectWorkdays(int project, int person)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetPersonAvailableProjectWorkdays";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pProject = new SqlParameter();
            pProject = command.Parameters.Add("@project", SqlDbType.Int);
            pProject.Direction = ParameterDirection.Input;
            pProject.Value = project;

            SqlParameter pPerson = new SqlParameter();
            pPerson = command.Parameters.Add("@person", SqlDbType.Int);
            pPerson.Direction = ParameterDirection.Input;
            pPerson.Value = person;

            SqlParameter pAvailableDays = new SqlParameter();
            pAvailableDays = command.Parameters.Add("@availableWorkDays", SqlDbType.Int);
            pAvailableDays.Direction = ParameterDirection.Output;
            pAvailableDays.Value = 0;



            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();

            }
            conn.Close();
            return (int)pAvailableDays.Value;
        }

        static public int GetPersonAvailableActivitiesWorkdays(int project, int person)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetPersonAvailableActivityWorkdays";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pProject = new SqlParameter();
            pProject = command.Parameters.Add("@project", SqlDbType.Int);
            pProject.Direction = ParameterDirection.Input;
            pProject.Value = project;

            SqlParameter pPerson = new SqlParameter();
            pPerson = command.Parameters.Add("@person", SqlDbType.Int);
            pPerson.Direction = ParameterDirection.Input;
            pPerson.Value = person;

            SqlParameter pAvailableDays = new SqlParameter();
            pAvailableDays = command.Parameters.Add("@availableWorkDays", SqlDbType.Int);
            pAvailableDays.Direction = ParameterDirection.Output;
            pAvailableDays.Value = 0;

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...");
                MessageBox.Show("Execute error: " + ex.Message);
                conn.Close();
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("απέτυχε η προσπάθεια... ");
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();
            return (int)pAvailableDays.Value;
        }
    }
}
