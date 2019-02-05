using BioinformaticsRosalindStrongHold.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioinformaticsRosalindStrongHold
{
    public partial class Form1 : Form
    {
        Stream  file = null;
        private string responce;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.OpenFile();
                label3.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Problems.GenericProblem problem = null;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "DNA":
                    problem = new DNA();
                    break;
                case "RNA":
                    problem = new RNA();
                    break;
                case "REVC":
                    problem = new REVC();
                    break;
                case "PROT":
                    problem = new PROT();
                    break;
                case "SUBS":
                    problem = new SUBS();
                    break;
            }
            responce=problem.Solve(problem.getReader(file));
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(responce);
        }
    }
}
