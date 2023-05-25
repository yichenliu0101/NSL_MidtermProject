using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjNSL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picPush_Click(object sender, EventArgs e)
        {
            new frmPush().Show();
        }

        private void picMember_Click(object sender, EventArgs e)
        {
            new frmMember().Show();
        }

        private void picTeacher_Click(object sender, EventArgs e)
        {
            new frmTeacher().Show();
        }

        private void picReport_Click(object sender, EventArgs e)
        {
            new frmReport().Show();
        }
    }
}
