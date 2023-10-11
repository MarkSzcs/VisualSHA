using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualSHA1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textBox1.Text);
            int[] bits = bytes.SelectMany(b => Convert.ToString(b, 2).PadLeft(8, '0')).Select(c => int.Parse(c.ToString())).ToArray();
            label1.Text = new StringBuilder().AppendJoin("", bits).Append("000 ...").Append(Convert.ToString(bits.Length, 2)).ToString();

        }
    }
}
