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
    public partial class frmTeacher : Form
    {
        int CategoryID;
        public frmTeacher()
        {
            InitializeComponent();
        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            CategoryID = comboBox1.SelectedIndex;
		}

		private void button1_Click(object sender, EventArgs e)
		{
            MessageBox.Show(CategoryID.ToString());
		}
	}
}
