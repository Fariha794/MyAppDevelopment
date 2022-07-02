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
    public partial class CRMsystem : Form
    {
        public CRMsystem()
        {
            InitializeComponent();
            findUF.Visible = true;
        }

        private void findUF1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addUF.Visible = true;
            findUF.Visible = false;
            editUF.Visible = false;
            deleteUF.Visible = false;
            printUF.Visible = false;
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            addUF.Visible = false;
            findUF.Visible = true;
            editUF.Visible = false;
            deleteUF.Visible = false;
            printUF.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addUF.Visible = false;
            findUF.Visible = false;
            editUF.Visible = false;
            deleteUF.Visible = true;
            printUF.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addUF.Visible = false;
            findUF.Visible = false;
            editUF.Visible = true;
            deleteUF.Visible = false;
            printUF.Visible = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            addUF.Visible = false;
            findUF.Visible = false;
            editUF.Visible = false;
            deleteUF.Visible = false;
            printUF.Visible = true;
        }

        private void addUF_Load(object sender, EventArgs e)
        {

        }
    }
}
