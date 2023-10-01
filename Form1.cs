using DataBaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sql_Database_app
{
    public partial class Form1 : Form
    {

        BindingSource ToolBindingSource = new BindingSource();
        BindingSource OffsetMagazineBindingSource = new BindingSource();
        BindingSource OffsetMachineBindingSource = new BindingSource();
        LimitationsTxtBox limitations = new LimitationsTxtBox();
        public Form1()
        {
            InitializeComponent();
            txtToolName.MaxLength = 30;
        }

        private void btLoadAll_Click(object sender, EventArgs e)
        {
            ToolDAO toolDAO = new ToolDAO();

            ToolBindingSource.DataSource = toolDAO.GetAllToolData();

            dtInfo.DataSource = ToolBindingSource;
        }

        private void txtToolNo_TextChanged(object sender, EventArgs e)
        {
          
            limitations.SetMaxNumberToTxtBox(ref sender, 1000);

            if (!String.IsNullOrWhiteSpace(txtToolNo.Text))
                SearchByToolNumber(sender);
     

      
        }
        private void txtToolNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitations.OnlyPassNumericToTxtBox(sender, e, false);
        }
        private void txtToolName_TextChanged(object sender, EventArgs e)
        {
            SearchByToolName(sender);
        }
        private void txtToolName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&!(char.IsControl(e.KeyChar));
        }


        private void SearchByToolName(object sender)
        {
            ToolDAO toolDAO = new ToolDAO();

            ToolBindingSource.DataSource = toolDAO.GetSearchToolName((sender as TextBox).Text);

            dtInfo.DataSource = ToolBindingSource;

        }

        private void SearchByToolNumber(object sender)
        {
            ToolDAO toolDAO = new ToolDAO();

            Int32.TryParse((sender as TextBox).Text, out int result);

            ToolBindingSource.DataSource = toolDAO.GetSearchToolNumber(result);

            dtInfo.DataSource = ToolBindingSource;

        }

        private void dtInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtInfo.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            DataGridView dataGridView = (DataGridView)sender;

            ToolDAO toolDAO = new ToolDAO();

            int rowClicked = dtInfo.CurrentRow.Index;

            OffsetMagazineBindingSource.DataSource = toolDAO.GetOffsetMagazine((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dtMagazine.DataSource = OffsetMagazineBindingSource;
            dtMagazine.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";



            OffsetMachineBindingSource.DataSource = toolDAO.GetOffsetMachine((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dtMachines.DataSource = OffsetMachineBindingSource;
            dtMachines.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";


            bool compareTool = CompareToolOffset(dtMagazine, dtMachines);

            if (compareTool)
                dtInfo.Rows[rowClicked].DefaultCellStyle.BackColor = Color.LightGreen;
            else
                dtInfo.Rows[rowClicked].DefaultCellStyle.BackColor = Color.IndianRed;

        }

        private bool CompareToolOffset(DataGridView Zoller, DataGridView Machine)
        {
            bool compareX = CompareGridColumn(Zoller, Machine, 1);
            bool compareY = CompareGridColumn(Zoller, Machine, 2);
            bool compareZ = CompareGridColumn(Zoller, Machine, 3);

            if (compareX && compareY && compareZ)
                return true;
            else
                return false;

        }

        private bool CompareGridColumn(DataGridView Zoller, DataGridView Machine, int Cell)
        {
            try
            {
                decimal magazineValue = (decimal)Zoller.Rows[0].Cells[Cell].Value;
                decimal machineValue = (decimal)Machine.Rows[0].Cells[Cell].Value;

                if (magazineValue == machineValue)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
