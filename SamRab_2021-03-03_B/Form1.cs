using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRab_2021_03_03_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float[] a = new float[1000];
        int n;

        private void button1_Click(object sender, EventArgs e)
        {
            n = textBox1.Lines.Count();
            textBox2.Text=Convert.ToString(n);
            textBox3.Clear();
            
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToSingle(textBox1.Lines[i]); 
                textBox3.Text = textBox3.Text +  Convert.ToString(a[i]) + "\r\n";
            } 
        }
    }
}
