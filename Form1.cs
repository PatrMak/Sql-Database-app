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


    }
}
