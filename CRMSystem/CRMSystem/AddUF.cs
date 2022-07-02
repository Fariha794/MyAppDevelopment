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
    public partial class AddUF : UserControl
    {
        public AddUF()
        {
            InitializeComponent();
        }

        private void phoneNumberAddLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddUF_Load(object sender, EventArgs e)
        {

        }

        private void saveAddButton_Click(object sender, EventArgs e)
        {
            if(nameAddTB.Text != "" && addressAddTB.Text != "" && phoneNumberAddTB.Text != "" && callStartedAddHoursTB.Text != "" && callStartedAddMinTB.Text != "" && callStartedAddSecondTB.Text != "" && callEndedAddHoursTB.Text != "" && callEndedAddMinTB.Text != "" && callEndedAddSecondTB.Text != "" && callRecordingLocationAddTB.Text != "" && ((feedbackAddPositiveRB.Checked== true) || feedbackAddNegativeRB.Checked == true))
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
