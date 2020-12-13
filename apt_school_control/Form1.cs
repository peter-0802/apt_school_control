using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace apt_school_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schoolControlUserControl1 a = new schoolControlUserControl1();
            tableLayoutPanel2.Controls.Add(a, 1, 0);
        }
    }
}
