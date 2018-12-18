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
    public partial class frmTimeSheet : BEAProjectManagement.frmTemplate
    {
        public int personID;
        DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow=-1;
        private DateTime dateFrom;
        private DateTime dateTo;

        public frmTimeSheet()
        {
            InitializeComponent();
        }

        private void tblOccupationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblOccupationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);     
        }
       
        private void frmTimeSheet_Load(object sender, EventArgs e)
        {

            this.dateTo = DateTime.Today;
            this.dateFrom = DateTime.Today.AddDays(-7);
            this.dateTimePicker1.Visible = false;
            this.monthCalendar1.Visible = false;      

            try
            {
                this.vActivityTeamTableAdapter.Fill(this.beaDBDataSet.vActivityTeam, this.personID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.tblOccupationsDataGridView;
            bnv = this.tblOccupationsBindingNavigator;
            DesignHelper.DesignDataGridView(dgv);
            DesignHelper.DesignDataGridNavigator(bnv);

            this.Text = "Απολογισμός Απασχόλησης";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Δραστηριότητα";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 400;

            dgv.Columns["dataGridViewTextBoxColumn3"].Visible = false;

            dgv.Columns["pickDate"].HeaderText = "";
            dgv.Columns["pickDate"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Ημερομηνία";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width =100;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Απασχόληση-ΑΩ";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 120;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Περιγραφή";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 120;

            LoadData();

            

        }

        private void tblOccupationsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == System.DBNull.Value)
            {
                if (e.RowIndex-1>=0 & dgv.Rows[e.RowIndex-1].Cells["dataGridViewTextBoxColumn2"].Value != System.DBNull.Value)
                    dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = dgv.Rows[e.RowIndex-1].Cells["dataGridViewTextBoxColumn2"].Value;                
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value = this.personID;
            }

            if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value == System.DBNull.Value)
            {
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value = this.dateTimePicker1.MinDate;
            }


            if (//person
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value != System.DBNull.Value &
                //date
                dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != System.DBNull.Value)
            {
                int person = (int)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value;
                DateTime date = (DateTime)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value;
                int occupation = 0;
                if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != System.DBNull.Value) {
                    occupation = (int)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value;
                }
                int workedHours = GetPersonDayWorkedHours(person, date, occupation);
                if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value != System.DBNull.Value)
                {
                    if ((int)dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value + workedHours > 8)
                    {
                        MessageBox.Show("Την ημερομηνία αυτή υπάρχουν ήδη " + workedHours.ToString() + " ώρες εργασίας");
                        dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value = 8 - workedHours;
                    }
                }
                else
                {                    
                    dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value = 8 - workedHours;   
                }                
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int dayofweek = (int)this.monthCalendar1.SelectionStart.DayOfWeek-1;            
            {
                dateFrom = this.monthCalendar1.SelectionStart.AddDays(-dayofweek);
            }
            dateTo = dateFrom.AddDays(6);
            this.monthCalendar1.Visible = false;          
            LoadData();
        }

        private void LoadData()
        {

            this.dateTimePicker1.MinDate = dateFrom;
            this.dateTimePicker1.MaxDate = dateTo;

            try
            {
                this.tblOccupationsTableAdapter.Fill(this.beaDBDataSet.tblOccupations, this.personID, this.dateFrom, this.dateTo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tblOccupationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;   
                if (e.ColumnIndex == dgv.Columns["pickDate"].Index)
                {
                    this.dateTimePicker1.Visible = true;
                    this.dateTimePicker1.Location = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value != System.DBNull.Value)
                    {
                        this.dateTimePicker1.Value = (Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value));
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentRow > -1)
            {
                dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.dateTimePicker1.Value;
                this.dateTimePicker1.Visible = false;
            }
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            if (CurrentRow > -1)
            {
                //dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn4"].Value = this.dateTimePicker1.Value;
                this.dateTimePicker1.Visible = false;
            }
        }

        private int GetPersonDayWorkedHours(int person, DateTime date, int occup)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.karposDBConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "pGetPersonDayWorkedHours";
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param = command.Parameters.Add("@personID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = person;

            SqlParameter pDate = new SqlParameter();
            pDate = command.Parameters.Add("@date", SqlDbType.SmallDateTime);
            pDate.Direction = ParameterDirection.Input;
            pDate.Value = date;

            SqlParameter pOccup = new SqlParameter();
            pOccup = command.Parameters.Add("@occupID", SqlDbType.Int);
            pOccup.Direction = ParameterDirection.Input;
            pOccup.Value = occup;

            SqlParameter returnParameter = new SqlParameter();
            returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

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

            }

            return Convert.ToInt16(returnParameter.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblOccupationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

            dgv.Sort(dgv.Columns[4], ListSortDirection.Ascending);
            
            /*
            foreach (DataGridViewRow r in dgv.Rows)
            {
                Color color = System.Drawing.ColorTranslator.FromHtml("#fff");
                int day;
                day = (int)((DateTime)r.Cells["dataGridViewTextBoxColumn4"].Value).DayOfWeek;
                if (day == 1)
                {
                    color=System.Drawing.ColorTranslator.FromHtml("#eeeaea");                    
                }
                else if (day == 2)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#e2dede");
                }
                else if (day == 3)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#d7d2d2");
                }
                else if (day == 4)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#cbc6c6");
                }
                else if (day == 5)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#bfb9b9");
                }
                else if (day == 6 || day==0)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#ccc");
                }
                r.DefaultCellStyle.BackColor=color;
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = true;
        }

        private void tblOccupationsDataGridView_Validated(object sender, EventArgs e)
        {
            this.Validate();
            this.tblOccupationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beaDBDataSet);

            //dgv.Sort(dgv.Columns[4], ListSortDirection.Ascending);

            foreach (DataGridViewRow r in dgv.Rows)
            {
                /*
                Color color = System.Drawing.ColorTranslator.FromHtml("#fff");
                int day;
                day = (int)((DateTime)r.Cells["dataGridViewTextBoxColumn4"].Value).DayOfWeek;
                if (day == 1)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#eeeaea");
                }
                else if (day == 2)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#e2dede");
                }
                else if (day == 3)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#d7d2d2");
                }
                else if (day == 4)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#cbc6c6");
                }
                else if (day == 5)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#bfb9b9");
                }
                else if (day == 6 || day == 0)
                {
                    color = System.Drawing.ColorTranslator.FromHtml("#ccc");
                }
                r.DefaultCellStyle.BackColor = color;
                */
            }
        }
    }
}
