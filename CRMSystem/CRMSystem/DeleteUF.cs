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
    public partial class DeleteUF : UserControl
    {
        public DeleteUF()
        {
            InitializeComponent();
        }


        private void findFindButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberDeleteTB.Text != "")
            {
                //delete
            }
            else
            {
                MessageBox.Show("Please Fill All the Field");
            }
        }
    }
}
