using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    public partial class frmSplash : Form
    {

        int time;
        public frmSplash()
        {
            InitializeComponent();
        }    
            

      

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.Text = "Εκκίνηση";
            time = 5;
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }

       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                frmLogin oform = new frmLogin();
                oform.Show();
                timer1.Stop();
                this.Hide();
            }
        }
    }    
}
