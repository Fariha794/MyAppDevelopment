using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class FindUF : UserControl
    {
        public FindUF()
        {
            InitializeComponent();
        }

        private void findFindButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberFindTB.Text!="")
            {
                //Store all info
            }
            else
            {
                MessageBox.Show("Please Fill All the Field");
            }
        }
    }
}
