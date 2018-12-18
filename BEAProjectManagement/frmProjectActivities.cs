using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmProjectActivities : BEAProjectManagement.frmTemplate
    {
        public int projectID;
        public DateTime projStart;
        public DateTime projFinish;
        DataGridView dgv;
        BindingNavigator bnv;

        int CurrentRow;

        public frmProjectActivities()
        {
            InitializeComponent();
        }

        private void tblProjectActivitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();

            this.lblBudget.Text = GetProjectWorkBudget(projectID).Item1.ToString();
            this.lblRemainingBudget.Text = GetProjectWorkBudget(projectID).Item2.ToString();

        }       

        private void frmProjectActivities_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblProjectActivitiesTableAdapter.Fill(this.beaDBDataSet.tblProjectActivities, this.projectID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblProjectActivitiesDataGridView;
            bnv = this.tblProjectActivitiesBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);
            this.Text = "Δραστηριότητες Έργου";

            this.Size = new Size(1200, 550);
            dgv.Size = new Size(1070, 300);

            this.lblCurrentProject.Text = bea.currentProject;
            this.lblCurrentProject.Location = new Point(320, 110);

            //MessageBox.Show("Available from Activities: " + bea.GetProjectAvailableHours(projectID).Item1.ToString() + " Available from People: " + bea.GetProjectAvailableHours(projectID).Item2.ToString());
            this.label2.Text = "Προυπολογισμός AH:";
            this.label4.Text = "Αδιάθετες ΑΗ:";
            this.lblBudget.Text = GetProjectWorkBudget(projectID).Item1.ToString();
            this.lblRemainingBudget.Text = GetProjectWorkBudget(projectID).Item2.ToString();

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Τίτλος";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 250;

            dgv.Columns["practCode"].HeaderText = "Κωδικός";
            dgv.Columns["practCode"].Width = 70;
            
            dgv.Columns["dataGridViewTextBoxColumn4"].Visible = false;

            dgv.Columns["dateFrom"].HeaderText = "";
            dgv.Columns["dateFrom"].Width = 50;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Έναρξη";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 100;

            dgv.Columns["dateTo"].HeaderText = "";
            dgv.Columns["dateTo"].Width = 50;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Λήξη";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 100;

            dgv.Columns["practBudget"].HeaderText = "Προυπολογισμός";
            dgv.Columns["practBudget"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "Απασχόληση-ΑΗ";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 120;

            dgv.Columns["practTeam"].HeaderText = "Ομάδα";
            dgv.Columns["practTeam"].Width = 80;
            dgv.Columns["practTeam"].Visible = true;

            dgv.Columns["Works"].HeaderText = "Ενέργειες";
            dgv.Columns["Works"].Width = 80;
            dgv.Columns["Works"].Visible = true;

        }

       
        private void tblProjectActivitiesDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {                  
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value) {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.projectID;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Η δρσαστηριότητα πρέπει να έχει ημερομηνία έναρξης!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value = this.projStart;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Η δρσαστηριότητα πρέπει να έχει ημερομηνία λήξης!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value = this.projFinish;
            }

            if (dgv.Rows[e.RowIndex].Cells["practCode"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Η δραστηριότητα πρέπει να έχει κωδικό!");
                dgv.Rows[e.RowIndex].Cells["practCode"].Value = "Κωδικός";
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Η δρσαστηριότητα πρέπει να έχει τίτλο!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value = "Τίτλος";
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value == System.DBNull.Value)
            {
                //MessageBox.Show("Η δρσαστηριότητα πρέπει να έχει προυπολογισμό ανρθωπο-ημερών εργασίας!");
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value = 0;
            }
        }

        private void tblProjectActivitiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pick calendar...
            if (e.RowIndex > -1)

                CurrentRow = e.RowIndex;
            {
                if (e.ColumnIndex == dgv.Columns["dateFrom"].Index && this.monthCalendar2.Visible == false)
                {
                    this.monthCalendar1.Visible = true;
                    this.monthCalendar1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar1.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["dateTo"].Index && this.monthCalendar1.Visible == false)
                {
                    this.monthCalendar2.Visible = true;
                    this.monthCalendar2.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value != System.DBNull.Value)
                    {
                        this.monthCalendar2.SetDate(Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value));
                    }
                }

                if (e.ColumnIndex == dgv.Columns["practTeam"].Index)
                {
                    SaveData();
                    frmActivityTeam frm = new frmActivityTeam();
                    frm.projID= Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value);
                    frm.practID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    bea.currentActivity = bea.GetCurrentActivity(frm.practID);
                    frm.Show();
                }    
                else if (e.ColumnIndex == dgv.Columns["Works"].Index)
                {
                    SaveData();
                    frmActivityWorks frm = new frmActivityWorks();
                    frm.practID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.practCodeTitle = dgv.Rows[e.RowIndex].Cells["practCode"].Value.ToString() + "-" + dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    frm.Show();                    
                }    
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn5"].Value = this.monthCalendar1.SelectionStart;
            this.monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn6"].Value = this.monthCalendar2.SelectionStart;
            this.monthCalendar2.Visible = false;
        }

        static public Tuple<int, int> GetProjectWorkBudget(int projectID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetProjectRemainingWorkBudget";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@project", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = projectID;

            SqlParameter pBudget = new SqlParameter();
            pBudget = command.Parameters.Add("@workBudget", SqlDbType.Int);
            pBudget.Direction = ParameterDirection.Output;
            pBudget.Value = 0;

            SqlParameter pRemainingBudget = new SqlParameter();
            pRemainingBudget = command.Parameters.Add("@workRemainingBudget", SqlDbType.Int);
            pRemainingBudget.Direction = ParameterDirection.Output;
            pRemainingBudget.Value = 0;

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
            return Tuple.Create((int)pBudget.Value, (int)pRemainingBudget.Value);
        }

        private void SaveData()
        {
            this.Validate();
            this.tblProjectActivitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);
        }
    }
}
