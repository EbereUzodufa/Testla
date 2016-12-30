using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for(i=0,i=F700ListBoxCourseCode.Items.Count-1,i++)
            {
           comboBox1.Items.Add(F700ListBoxCourseCode.Items.Add(i));
            }
        }
    }
}
