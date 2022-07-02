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
    public partial class EditUF : UserControl
    {
        public EditUF()
        {
            InitializeComponent();
        }

        private void findFindButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberEditTB.Text != "")
            {
                //edit
            }
            else
            {
                MessageBox.Show("Please Fill All the Field");
            }
        }
    }
}
