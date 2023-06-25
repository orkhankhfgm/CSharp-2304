using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class TestFromWindow : Form
    {
        public TestFromWindow()
        {
            InitializeComponent();

            this.button1.Text = "Click me!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
