using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEAProjectManagement
{
    class DesignHelper
    {

            public void MarkDropDownColumns(DataGridView dgv, string name)
            {
                dgv.Columns[name].DefaultCellStyle.BackColor = Color.GhostWhite;
            }

            public static void InactivateColumn(DataGridView dgv, int i)
            {
                dgv.Columns[i].ReadOnly = true;
                dgv.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
                dgv.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

            public void InactivateNavigator(BindingNavigator nav)
            {
                nav.AddNewItem.Visible = false;
                nav.DeleteItem.Visible = false;
                nav.Enabled = true;
            }

            public void InactivateDataGrid(DataGridView dgv)
            {
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
            }

            public static void DesignDataGridView(DataGridView dg)
            {
                //dg.Columns(0).Visible = False
                dg.Location = new Point(9, 140);
                dg.Size = new Size(987, 350);
                dg.Font = new Font("Century Gothic", 8.75f);
                dg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                dg.AllowUserToAddRows = false;
            //dg.Dock = DockStyle.Fill;
                dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dg.AllowUserToResizeRows = false;
                dg.RowTemplate.Height = 30;
                dg.ScrollBars = ScrollBars.Both;
            
                //dg.Columns(0).Visible = False

            }

            public static void DesignDataGridNavigator(BindingNavigator dgn)
            {
                dgn.Location = new Point(9, 110);
                dgn.Dock = DockStyle.None;
            }
        }
    
}
